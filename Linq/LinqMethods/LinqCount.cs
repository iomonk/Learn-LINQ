using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqCount
    {
        private const string AfterCountStr =
            "The list after the 'Count' method is applied. There are 100 elements in the list.";

        public static void CountMethod(IEnumerable<Person> personList)
        {
            var personToList = personList.ToList();
            AfterCount(personToList);
        }

        private static void AfterCount(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterCountStr);
            var result = personList.Count();
            Console.WriteLine(result);
        }
    }
}