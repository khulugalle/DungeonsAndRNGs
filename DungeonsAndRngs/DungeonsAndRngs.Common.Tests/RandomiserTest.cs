using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DungeonsAndRngs.Common.Randomisation;

namespace DungeonsAndRngs.Common.Tests
{
    [TestClass]
    public class RandomiserTest
    {
        protected Randomiser randomiser;

        [TestInitialize]
        public void Setup()
        {
            if (randomiser == null)
            {
                int seed = 1928372983;
                randomiser = Randomiser.Instance;
                randomiser.Reset(seed);
            }
        }

        [TestMethod]
        public void TestRollD2ReturnsNumberBetween1And2()
        {
            //Arrange
            Assert.IsNotNull(randomiser);

            //Act
            int roll = randomiser.RollD2();

            //Assert
            Assert.IsTrue(roll >= 1);
            Assert.IsTrue(roll <= 2);
        }

        [TestMethod]
        public void TestRollD2ReturnsNumberBetween1And2For100000Times()
        {
            //Arrange
            int times = 10000;

            //Act, Assert
            for (int i = 0; i < times; i++)
            {
                TestRollD2ReturnsNumberBetween1And2();
            }
        }

        [TestMethod]
        public void TestRollD3ReturnsNumberBetween1And3()
        {
            //Arrange
            Assert.IsNotNull(randomiser);

            //Act
            int roll = randomiser.RollD3();

            //Assert
            Assert.IsTrue(roll >= 1);
            Assert.IsTrue(roll <= 3);
        }

        [TestMethod]
        public void TestRollD3ReturnsNumberBetween1And3For100000Times()
        {
            //Arrange
            int times = 10000;

            //Act, Assert
            for (int i = 0; i < times; i++)
            {
                TestRollD3ReturnsNumberBetween1And3();
            }
        }

        [TestMethod]
        public void TestRollD4ReturnsNumberBetween1And4()
        {
            //Arrange
            Assert.IsNotNull(randomiser);

            //Act
            int roll = randomiser.RollD4();

            //Assert
            Assert.IsTrue(roll >= 1);
            Assert.IsTrue(roll <= 4);
        }

        [TestMethod]
        public void TestRollD4ReturnsNumberBetween1And4For100000Times()
        {
            //Arrange
            int times = 10000;

            //Act, Assert
            for (int i = 0; i < times; i++)
            {
                TestRollD4ReturnsNumberBetween1And4();
            }
        }

        [TestMethod]
        public void TestRollD7ReturnsNumberBetween1And7()
        {
            //Arrange
            Assert.IsNotNull(randomiser);

            //Act
            int roll = randomiser.RollD7();

            //Assert
            Assert.IsTrue(roll >= 1);
            Assert.IsTrue(roll <= 7);
        }

        [TestMethod]
        public void TestRollD7ReturnsNumberBetween1And7For100000Times()
        {
            //Arrange
            int times = 10000;

            //Act, Assert
            for (int i = 0; i < times; i++)
            {
                TestRollD7ReturnsNumberBetween1And7();
            }
        }

        [TestMethod]
        public void TestRollD8ReturnsNumberBetween1And8()
        {
            //Arrange
            Assert.IsNotNull(randomiser);

            //Act
            int roll = randomiser.RollD8();

            //Assert
            Assert.IsTrue(roll >= 1);
            Assert.IsTrue(roll <= 8);
        }

        [TestMethod]
        public void TestRollD8ReturnsNumberBetween1And8For100000Times()
        {
            //Arrange
            int times = 10000;

            //Act, Assert
            for (int i = 0; i < times; i++)
            {
                TestRollD8ReturnsNumberBetween1And8();
            }
        }

        [TestMethod]
        public void TestRollD10ReturnsNumberBetween1And10()
        {
            //Arrange
            Assert.IsNotNull(randomiser);

            //Act
            int roll = randomiser.RollD10();

            //Assert
            Assert.IsTrue(roll >= 1);
            Assert.IsTrue(roll <= 10);
        }

        [TestMethod]
        public void TestRollD10ReturnsNumberBetween1And10For100000Times()
        {
            //Arrange
            int times = 10000;

            //Act, Assert
            for (int i = 0; i < times; i++)
            {
                TestRollD10ReturnsNumberBetween1And10();
            }
        }

        [TestMethod]
        public void TestRollD12ReturnsNumberBetween1And12()
        {
            //Arrange
            Assert.IsNotNull(randomiser);

            //Act
            int roll = randomiser.RollD12();

            //Assert
            Assert.IsTrue(roll >= 1);
            Assert.IsTrue(roll <= 12);
        }

        [TestMethod]
        public void TestRollD12ReturnsNumberBetween1And12For100000Times()
        {
            //Arrange
            int times = 10000;

            //Act, Assert
            for (int i = 0; i < times; i++)
            {
                TestRollD12ReturnsNumberBetween1And12();
            }
        }

        [TestMethod]
        public void TestRollD20ReturnsNumberBetween1And20()
        {
            //Arrange
            Assert.IsNotNull(randomiser);

            //Act
            int roll = randomiser.RollD20();

            //Assert
            Assert.IsTrue(roll >= 1);
            Assert.IsTrue(roll <= 20);
        }

        [TestMethod]
        public void TestRollD20ReturnsNumberBetween1And20For100000Times()
        {
            //Arrange
            int times = 10000;

            //Act, Assert
            for (int i = 0; i < times; i++)
            {
                TestRollD20ReturnsNumberBetween1And20();
            }
        }

        [TestMethod]
        public void TestRollD100ReturnsNumberBetween1And100()
        {
            //Arrange
            Assert.IsNotNull(randomiser);

            //Act
            int roll = randomiser.RollD100();

            //Assert
            Assert.IsTrue(roll >= 1);
            Assert.IsTrue(roll <= 100);
        }

        [TestMethod]
        public void TestRollD100ReturnsNumberBetween1And100For100000Times()
        {
            //Arrange
            int times = 10000;

            //Act, Assert
            for (int i = 0; i < times; i++)
            {
                TestRollD100ReturnsNumberBetween1And100();
            }
        }
    }
}
