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
            Assert.AreEqual(new Occurrence[]
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
            Occurrence[] list = new Occurrence[words.Length];
            string[] keeper = new string[words.Length];
            for (int i = 0; i < words.Length - 1; i++)
            {
                int pos = Array.IndexOf(keeper, words[i]);
                if (pos == -1)
                {
                    int counter = 1;
                    keeper[i] = words[i];
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                            counter++;
                    }
                    list[i] = new Occurrence(words[i], counter);
                }
            }
            return list;
        }
    }
}
