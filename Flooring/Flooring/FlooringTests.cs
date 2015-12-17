using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flooring
{
    [TestClass]
    public class FlooringTests
    {
        [TestMethod]
        public void MostSimpleExample()
        {
            float neededPieces = CalculateFloorPieces(1, 1, 1, 1);
            Assert.AreEqual(2, neededPieces);
        }
        float CalculateFloorPieces(int roomLength, int roomWidth, int pieceLength, int pieceWidth)
        {
            int roomArea = roomLength * roomWidth;
            int pieceArea = pieceLength * pieceWidth;
            int principalNumberOfNeededPieces = roomArea / pieceArea;
            float loss = (15 / 100) * principalNumberOfNeededPieces;
            float finalNumberOfNeededPieces = principalNumberOfNeededPieces + loss;
            Math.Ceiling(finalNumberOfNeededPieces);
            return (finalNumberOfNeededPieces);
        }
    }
}
