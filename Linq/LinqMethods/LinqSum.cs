using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqSum
    {
        public static void SumMethod(IEnumerable<Person> personList)
        {
            var personToList = personList.ToList();
            AfterSum(personToList);
        }
        
        private static void AfterSum(IEnumerable<Person> personList)
        {
            Console.WriteLine("The list After the 'Sum' method is applied. Shows the sum of all the ages.");
            var summedAges = personList.Sum(x => x.Age);
            Console.WriteLine(summedAges);
        }
    }
}