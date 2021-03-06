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
            //var split = parameters.Split(new Char[] {',', '\n'});

            //var flattenArray = split.SelectMany(x => x).Distinct().ToArray();

            
            
      
            
            //var numericArray = Array.ConvertAll(split, c => (int) Char.GetNumericValue(c));

            //throw new ArgumentException($"wrong");



            var array = parameters.Replace(",", String.Empty).Replace("\n", String.Empty)
                .Select(x => int.Parse(x.ToString())).ToArray();
            return array.Sum();
        }


    }
}
