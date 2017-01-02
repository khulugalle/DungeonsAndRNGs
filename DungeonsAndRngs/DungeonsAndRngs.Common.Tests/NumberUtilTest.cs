using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DungeonsAndRngs.Common.Utility;

namespace DungeonsAndRngs.Common.Tests
{
    [TestClass]
    public class NumberUtilTest
    {
        [TestMethod]
        public void TestRoundToNearestRoundsUpToCorrectNumbers()
        {
            //Arrange
            double number = 14.365546;
            double precision = 0.1;

            //Act
            double rounding = NumberUtil.RoundToNearest(number, precision);

            //Assert
            Assert.AreEqual(14.4, rounding);
        }

        [TestMethod]
        public void TestRoundToNearestRoundsDownToCorrectNumbers()
        {
            //Arrange
            double number = 14.42265;
            double precision = 0.1;

            //Act
            double rounding = NumberUtil.RoundToNearest(number, precision);

            //Assert
            Assert.AreEqual(14.4, rounding);
        }

        [TestMethod]
        public void TestRoundToCeilingRoundsToCorrectNumbers()
        {
            //Arrange
            double number = 14.3001;
            double precision = 0.1;

            //Act
            double rounding = NumberUtil.RoundToCeiling(number, precision);

            //Assert
            Assert.AreEqual(14.4, rounding);
        }
    }
}
