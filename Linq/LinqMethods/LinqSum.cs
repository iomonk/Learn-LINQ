using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqSum
    {
        // strings used throughout the LinqSum Class
        private const string AfterSumStr = "The list After the 'Sum' method is applied. Shows the sum of all the ages.";
        
        public static void SumMethod(IEnumerable<Person> personList)
        {
            var personToList = personList.ToList();
            AfterSum(personToList);
        }
        
        private static void AfterSum(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterSumStr);
            var summedAges = personList.Sum(x => x.Age);
            Console.WriteLine(summedAges);
        }
    }
}