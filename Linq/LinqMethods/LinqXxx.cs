using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqXxx
    {
        // strings used throughout the LinqXxx Class
        private const string AfterXxxStr = "The list After the 'Xxx' method is applied.";
        
        public static void XxxMethod(IEnumerable<Person> personList)
        {
            var personToList = personList.ToList();
            AfterXxx(personToList);
        }
        
        private static void AfterXxx(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterXxxStr);
            var summedAges = personList.Sum(x => x.Age);
            Console.WriteLine(summedAges);
        }
    }
}