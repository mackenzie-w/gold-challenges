using System;
using System.Collections.Generic;
using Challenge_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_1_Tests
{
    [TestClass]
    public class UnitTest1
    {
        MenuRepository menuRepo = new MenuRepository();
        [TestMethod]
        public void MenuRepository_GetList_CountShouldBeSame()
        {
            //-- Arrange
            List<Menu> menuListTest = menuRepo.GetList();

            //-- Act
            int actual = menuListTest.Count;
            int expected = 0;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepository_RemoveItem_CountShouldDecrease()
        {
            //-- Arrange
            Menu meal = new Menu(1, "Waffles", "Some more waffles.", "Even more waffles and syrup.", 10.00m);
            menuRepo.AddItemToList(meal);
            menuRepo.RemoveItemFromList(1);
            List<Menu> menuListTest = menuRepo.GetList();

            //--Act
            int actual = menuListTest.Count;
            int expected = 0;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepository_AddItem_CountShouldIncrease()
        {
            //-- Arrange
            Menu meal = new Menu(1, "Waffles", "Some waffles.", "Waffles, syrup, and more waffles.", 10.00m);
            menuRepo.AddItemToList(meal);
            List<Menu> menuListTest = menuRepo.GetList();

            //-- Act
            int actual = menuListTest.Count;
            int expected = 1;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
