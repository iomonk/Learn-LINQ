using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqAverage
    {
        private const string AfterAverageStr =
            "The list after the 'Average' method is applied. Computes the average of all ages.";

        public static void AverageMethod(IEnumerable<Person> personList)
        {
            AfterAverage(personList);
        }

        private static void AfterAverage(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterAverageStr);
            var result = personList.Average(x => x.Age);
            Console.WriteLine(result);
        }
    }
}