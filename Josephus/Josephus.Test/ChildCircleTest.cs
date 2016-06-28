using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Josephus.Resources;

namespace Josephus.Test
{
    [TestClass]
    public class ChildCircleTest
    {
        [TestMethod]
        public void ChildCircle_ReturnsCorrectWinner()
        {
            var circle = new ChildCircle(5, 2);
            var winner = circle.GetWinner();

            Assert.AreEqual(winner, 3);
            Assert.AreEqual(circle.RemovedChildren.Count, 4);
            Assert.AreEqual(circle.RemovedChildren[0], 2);
            Assert.AreEqual(circle.RemovedChildren[1], 4);
            Assert.AreEqual(circle.RemovedChildren[2], 1);
            Assert.AreEqual(circle.RemovedChildren[3], 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ChildCircle_ThrowsArgumentException_WhenInvalidNumberOfChildrenParameter()
        {
            try
            {
                var circle = new ChildCircle(0, 2);
            }
            catch (ArgumentException exc)
            {
                Assert.AreEqual(JosephusTestResources.NumberOfChildrenArgumentException, exc.Message);
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ChildCircle_ThrowsArgumentException_WhenInvalidEliminatePositionParameter()
        {
            try
            {
                var circle = new ChildCircle(1, -2);
            }
            catch (ArgumentException exc)
            {
                Assert.AreEqual(JosephusTestResources.EliminatePositionArgumentException, exc.Message);
                throw;
            }
        }
    }
}