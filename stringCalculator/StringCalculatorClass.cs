using System;
using System.Collections.Generic;
using System.Linq;

namespace stringCalculator
{
    public class StringCalculatorClass
    {
        public int Calculate(string parameters)
        {
            return string.IsNullOrEmpty(parameters) ? 0 : Addition(parameters);
        }

        private int Addition(string parameters)
        {

            var parametersWithoutStrings = RemoveStrings(parameters);
            var validatedArray = ValidateNumbers(parametersWithoutStrings);
            return validatedArray.Sum();
        }

        private int[] ValidateNumbers(int[] parameters)
        {
            List<int> negativeNumbers = parameters.Where(number => number < 0).ToList();


            if (negativeNumbers.Count > 0)
            {
                
                throw new ArgumentException($"error: negatives not allowed");
            }

            return parameters;
        }

        private int[] RemoveStrings(string parameters)
        {
            string[] split = parameters.Split(new Char[] {',', '\n'}).ToArray();

            int[] array = Array.ConvertAll(split, Int32.Parse);

            return array;
        }
    }
}

