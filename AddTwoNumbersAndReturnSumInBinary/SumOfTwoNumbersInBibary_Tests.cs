using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbersAndReturnSumInBinary
{
    [TestFixture]
    public class SumOfTwoNumbersInBibary_Tests
    {
        [TestCase(1, 2, "11")]
        [TestCase(11, 12, "10111")]
        [TestCase(49, 51, "1100100")]
        public void GetBinaryFormOfSumOfTwoNumbers_GivenTwoNumberShouldAddThemAndReturnBinaryFormOfSum(int firstNumber, int secondNumber,string expected)
        {
            //---------------------------Arrange----------------------------
            var sumOfTwoNumbersInBibary = new SumOfTwoNumbersInBinary();

            //---------------------------Act--------------------------------
            var actual = sumOfTwoNumbersInBibary.GetBinaryFormOfSumOfTwoNumbers(firstNumber, secondNumber);

            //---------------------------Assert-----------------------------
            Assert.AreEqual(expected, actual);
        }
    }
}
