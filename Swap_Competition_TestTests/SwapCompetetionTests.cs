using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swap_Competition_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Competition_Test.Tests
{
    [TestClass()]
    public class SwapCompetetionTests
    {
        [TestMethod()]
        public void CanRearrangeTest()
        {
            string word1 = "abcde";
            string word2 = "bcdea";
            bool expected1 = false;
            bool expected2 = true;

            //Act
            SwapCompetetion swapCompetetion = new SwapCompetetion();
            bool actual = swapCompetetion.CanRearrange(word1, word2);

            //Assert
            
            Assert.AreEqual(expected2, actual);
        }
    }
}