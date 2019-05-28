using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StolenBreakfastDrone;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void OneDroneTest()
        {
            var expected = 1;
            var actual = DroneManager.FindUniqueDeliveryId(new int[] { 1 });
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UniqueIdComesFirstTest()
        {
            var expected = 1;
            var actual = DroneManager.FindUniqueDeliveryId(new int[] { 1, 2, 2 });
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UniqueIdComesLastTest()
        {
            var expected = 1;
            var actual = DroneManager.FindUniqueDeliveryId(new int[] { 3, 3, 2, 2, 1 });
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UniqueIdInTheMiddleTest()
        {
            var expected = 1;
            var actual = DroneManager.FindUniqueDeliveryId(new int[] { 3, 2, 1, 2, 3 });
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ManyDronesTest()
        {
            var expected = 8;
            var actual = DroneManager.FindUniqueDeliveryId(new int[] { 2, 5, 4, 8, 6, 3, 1, 4, 2, 3, 6, 5, 1 });
            Assert.AreEqual(expected, actual);
        }
    }
}
