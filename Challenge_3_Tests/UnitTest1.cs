using System;
using System.Collections.Generic;
using Challenge_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_3_Tests
{
    [TestClass]
    public class UnitTest1
    {
        OutingRepository outingRepo = new OutingRepository();
        [TestMethod]
        public void outingRepository_GetList_CountShouldBeSame()
        {
            //-- Arrange
            List<Outing> outingListTest = outingRepo.GetList();

            //-- Act
            int actual = outingListTest.Count;
            int expected = 0;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OutingRepository_AddItem_CountShouldIncrease()
        {
            //-- Arrange
            Outing outing1 = new Outing(7, "10/10/2010", 25.00m, 175.00, (OutingType)1);
            outingRepo.AddOutingToList(outing1);
            List<Outing> outingListTest = outingRepo.GetList();

            //-- Act
            int actual = outingListTest.Count;
            int expected = 1;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
