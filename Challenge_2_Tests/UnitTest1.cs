using System;
using System.Collections.Generic;
using Challenge_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_2_Tests
{
    [TestClass]
    public class UnitTest1
    {
        ClaimRepository claimRepo = new ClaimRepository();
        [TestMethod]
        public void ClaimRepository_GetQueue_CountShouldBeSame()
        {
            //-- Arrange
            Queue<Claim> claimQueueTest = claimRepo.GetQueue();

            //-- Act
            int actual = claimQueueTest.Count;
            int expected = 0;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClaimRepository_RemoveItemFromQueue_CountShouldDecrease()
        {
            //-- Arrange
            Claim claim1 = new Claim(1, "Car", "Car Accident", 5000.00, "12/21/2012", "12/31/2012");
            claimRepo.AddToQueue(claim1);
            claimRepo.RemoveFromQueue();
            Queue<Claim> claimQueueTest = claimRepo.GetQueue();

            //--Act
            int actual = claimQueueTest.Count;
            int expected = 0;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClaimRepository_AddItemToQueue_CountShouldIncrease()
        {
            //-- Arrange
            Claim claim2 = new Claim(2, "Home", "House Fire", 7500.00, "01/15/2013", "02/24/2013");
            claimRepo.AddToQueue(claim2);
            Queue<Claim> claimQueueTest = claimRepo.GetQueue();

            //-- Act
            int actual = claimQueueTest.Count;
            int expected = 1;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClaimRepository_LookAtNextItem_SeeTopStackClaim()
        {
            //-- Arrange
            Queue<Claim> clai = new Queue<Claim>();
            Claim claim1 = new Claim(1, "Car", "Car Accident", 5000.00, "12/21/2012", "12/31/2012");
            Claim claim2 = new Claim(2, "Home", "House Fire", 7500.00, "01/15/2013", "02/24/2013");
            claimRepo.AddToQueue(claim1);
            claimRepo.AddToQueue(claim2);
            claimRepo.LookAtNextItem();

            //-- Act
            var actual = claimRepo.LookAtNextItem();
            var expect = claim1;

            //-- Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
