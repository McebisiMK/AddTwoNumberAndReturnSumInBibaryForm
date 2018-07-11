using System.Collections.Generic;

namespace AddTwoNumbersAndReturnSumInBinary
{
    public class SumOfTwoNumbersInBinary
    {
        public string GetBinaryFormOfSumOfTwoNumbers(int firstNumber, int secondNumber)
        {
            var sumOfTwoNumbers = firstNumber + secondNumber;
            var binaryForm = new List<string>();
            while(sumOfTwoNumbers > 0)
            {
                var remainder = sumOfTwoNumbers % 2;
                sumOfTwoNumbers = (sumOfTwoNumbers - remainder) / 2;
                binaryForm.Add(remainder.ToString());
            }
            binaryForm.Reverse();
            return $"{string.Join("", binaryForm)}";
            //This can do it but I was focusing on understanding the whole process(logic)
            //return Convert.ToString(firstNumber + secondNumber, 2);
        }
    }
}