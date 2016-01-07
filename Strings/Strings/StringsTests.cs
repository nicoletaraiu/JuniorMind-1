using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Strings
{
    [TestClass]
    public class StringsTests
    {
        [TestMethod]
        public void FirstTest()
        {
            string prefix = StringComparison("aaab", "aaaabbaa");
            Assert.AreEqual("aaa", prefix);
        }
        string StringComparison(string firstString, string secondString) {
            string prefix = "";
            while ((firstString.Length != 0) && (secondString.Length != 0))
                for (int i = 0; i < firstString.Length; ++i)
                {
                    for (int j = 0; j < secondString.Length; ++j)
                    {
                        if (firstString[i] == secondString[j])
                            prefix = prefix + firstString[i];
                    } 
                }
            return prefix;
        }
    }
}
