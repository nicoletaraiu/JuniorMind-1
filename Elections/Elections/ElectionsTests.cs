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
            var sorted = new Candidate[] {
            new Candidate("Marcel", 1000),
            new Candidate("Alex", 998),
            new Candidate("Costel", 784),
            new Candidate("Vasile", 554),
            new Candidate("Cosmin", 449) };
            CollectionAssert.AreEqual(sorted, Sort(new Candidate[] {
                new Candidate("Vasile", 554),
                new Candidate("Cosmin", 449),
                new Candidate("Alex", 998),
                new Candidate("Costel", 784),
                new Candidate("Marcel", 1000) }));
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

            public Candidate[] Sort(Candidate[] candidates)
            {
                return candidates;
            }

        }
}
