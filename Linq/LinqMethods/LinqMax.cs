using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqMax
    {
        private const string AfterMaxStr =
            "The list after the 'Max' method is applied. Returns the oldest age in the list.";

        public static void MaxMethod(IEnumerable<Person> personList)
        {
            AfterMax(personList);
        }

        private static void AfterMax(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterMaxStr);
            var result = personList.Max(x => x.Age);
            Console.WriteLine(result);
        }
    }
}