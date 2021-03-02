using System;
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

            var array = parameters.Replace(",", String.Empty).Select(x => int.Parse(x.ToString())).ToArray();
            return array.Sum();
        }
    }
}