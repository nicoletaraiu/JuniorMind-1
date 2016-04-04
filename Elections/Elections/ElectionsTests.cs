using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elections
{
    [TestClass]
    public class ElectionsTests
    {
        [TestMethod]
        public void ShouldSortCandidates()
        {
            var lists = new List[] {
            new List(new Candidate[] {
                new Candidate("Vasile", 1200),
                new Candidate("Cosmin", 900),
                new Candidate("Alex", 800),
                new Candidate("Costel", 600),
                new Candidate("Marcel", 500)}),
            new List(new Candidate[] {
                new Candidate("Costel", 700),
                new Candidate("Alex", 500),
                new Candidate("Cosmin", 300),
                new Candidate("Vasile", 200),
                new Candidate("Marcel", 100) }),
            new List(new Candidate[] {
                new Candidate("Vasile", 1200),
                new Candidate("Costel", 1100),
                new Candidate("Alex", 900),
                new Candidate("Cosmin", 700),
                new Candidate("Marcel", 500) }) };
            var sorted = new Candidate[]
            {
                new Candidate("Alex", 2200),
                new Candidate("Cosmin", 1900),
                new Candidate("Costel", 2400),
                new Candidate("Marcel", 1100),
                new Candidate("Vasile", 2600)   
            };
            CollectionAssert.AreEqual(sorted, Sort(lists));
        }
        [TestMethod]
        public void ShouldSortAlphabetically()
        {
            var firstList = new Candidate[] {
                new Candidate("Vasile", 1200),
                new Candidate("Cosmin", 900),
                new Candidate("Alex", 800),
                new Candidate("Costel", 600),
                new Candidate("Marcel", 500) };
            var sorted = new Candidate[] {
                new Candidate("Alex", 800),
                new Candidate("Cosmin", 900),
                new Candidate("Costel", 600),
                new Candidate("Marcel", 500),
                new Candidate("Vasile", 1200) };
            var secondList = new Candidate[] {
                new Candidate("Costel", 700),
                new Candidate("Alex", 500),
                new Candidate("Cosmin", 300),
                new Candidate("Vasile", 200),
                new Candidate("Marcel", 100) };
            var secondSorted = new Candidate[] {
                new Candidate("Alex", 500),
                new Candidate("Cosmin", 300),
                new Candidate("Costel", 700),
                new Candidate("Marcel", 100),
                new Candidate("Vasile", 200) };
            CollectionAssert.AreEqual(sorted, SortAlphabetically(firstList));
            CollectionAssert.AreEqual(secondSorted, SortAlphabetically(secondList));
        }
        
        public struct List
        {
            public Candidate[] candidates;

            public List(Candidate[] candidates)
            {
                this.candidates = candidates;
            }
        }

        public struct Candidate
        {
            public string name;
            public int votes;

            public Candidate(string name, int votes)
            {
                this.name = name;
                this.votes = votes;
            }
        }

        public static Candidate[] Sort(List[] lists)
        {  
            List[] sortedAlphabetically = new List[lists.Length];
            Candidate[] sorted = new Candidate[lists[0].candidates.Length];
            for (int i = 0; i < sortedAlphabetically.Length; i++)
            {
                sortedAlphabetically[i].candidates = SortAlphabetically(lists[i].candidates);
            }
           
            for (int i = 0; i < sorted.Length; i++)
            {
                int totalVotes = 0;
                string name = "";
                for (int j = 0; j < sortedAlphabetically.Length; j++)
                {   
                    totalVotes += sortedAlphabetically[j].candidates[i].votes;
                    name = sortedAlphabetically[j].candidates[i].name;
                }
                sorted[i] = new Candidate(name, totalVotes);
            }
            return sorted;
        }

        public static Candidate[] SortAlphabetically(Candidate[] candidates)
        {
            for (int i = 0; i < candidates.Length; i++)
            {
                for (int j = 0; j < candidates.Length - 1; j++)
                {
                    if (String.Compare(candidates[j].name, candidates[j + 1].name) > 0)
                        Swap(ref candidates[j], ref candidates[j + 1]);
                }
            }
            return candidates;
        }

        static void Swap(ref Candidate first, ref Candidate second)
        {
            Candidate temp = first;
            first = second;
            second = temp;
        }

    }
}
