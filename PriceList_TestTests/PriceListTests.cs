using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day9_PracticeProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_PracticeProblem.Tests
{
    [TestClass]
    public class PriceListTests
    {
        [TestMethod]
        public void PriceList()
        {
            //Arrange
            int[] arr = { 7, 5, 4, 7, 94, 1, 11 };
            int soldForOnce = 5;
            int soldMoreThanOnce = 7;
            // int[] expected = { soldForOnce, soldMoreThanOnce };

            //Act
            PriceList priceList = new PriceList();
            int[] actual = priceList.PriceListForSoldItem();

            //Assert
            Assert.AreEqual(actual[0], soldForOnce);
            Assert.AreEqual(actual[1], soldMoreThanOnce); ;
        }
    }
}