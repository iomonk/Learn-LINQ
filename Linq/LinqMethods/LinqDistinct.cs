using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;
using Linq.Service;

namespace Linq.LinqMethods
{
    public static class LinqDistinct
    {
        private const string AfterDistinctStr = "The list after the 'Distinct' method is applied. Displays all the locations used in the list. No duplicates.";

        public static void DistinctMethod(IEnumerable<Person> personList)
        {
            AfterDistinct(personList);
        }

        private static void AfterDistinct(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterDistinctStr);
            var result = personList.Select(x => x.Location).Distinct();
            foreach (var p in result) Console.WriteLine(p);
        }
    }
}