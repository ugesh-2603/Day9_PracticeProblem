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
            int[] arr = { 5, 7, 1, 8, 24, 11, 6 };
            int soldForOnce = 5;
            int soldMoreThanOnce = 7;
           

            //Act
            PriceList priceList = new PriceList();
            int[] actual = priceList.PriceListForSoldItem();

            //Assert
            Assert.AreEqual(actual[0], soldForOnce);
            Assert.AreEqual(actual[1], soldMoreThanOnce); ;
        }
    }
}
