using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Text
{
    [TestClass]
    public class TextTests
    {
        [TestMethod]
        public void ShouldReturnTheStatistic()
        {
            CollectionAssert.AreEqual(new Occurrence[]
            {
                new Occurrence("cinci", 5),
                new Occurrence("patru", 4),
                new Occurrence("trei", 3),
                new Occurrence("doi", 2),
                new Occurrence("unu", 1)
            }, Sort("cinci unu trei cinci trei patru doi cinci patru trei patru doi cinci patru cinci"));
        }

        public struct Occurrence
        {
            public string word;
            public int occurrences;

            public Occurrence(string word, int occurrences)
            {
                this.word = word;
                this.occurrences = occurrences;
            }
        }

        Occurrence[] Sort(string Text)
        {
            string[] words = Text.Split(' ');
            Occurrence[] list = new Occurrence[0];
            string[] keeper = new string[words.Length];
            for (int i = 0; i < words.Length - 1; i++)
            {
                int pos = Array.IndexOf(keeper, words[i]);
                keeper[i] = words[i];
                if (pos == -1)
                {
                    int counter = 1;
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                            counter++;
                    }
                    Array.Resize(ref list, list.Length + 1);
                    list[list.Length - 1] = new Occurrence(words[i], counter);
                }
                else continue;
            }
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length - 1; j++)
                {
                    if (list[j].occurrences < list[j + 1].occurrences)
                        Swap(ref list[j], ref list[j + 1]);
                }
            }
            return list;
        }
        
        static void Swap(ref Occurrence a, ref Occurrence b)
        {
            Occurrence temp = a;
            a = b;
            b = temp;
        }
    }
}
