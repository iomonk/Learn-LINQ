using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqElementAt
    {
        private const string AfterElementAtStr =
            "The list after the 'ElementAt' method is applied. Returns whatever element exists at 42";

        public static void ElementAtMethod(IEnumerable<Person> personList)
        {
            AfterElementAt(personList);
        }

        private static void AfterElementAt(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterElementAtStr);
            var result = personList.ElementAt(42);
            Console.WriteLine(
                $"{nameof(result.Id)}: {result.Id} {nameof(result.FirstName)}: {result.FirstName} {nameof(result.LastName)}: {result.LastName}: {nameof(result.Age)}: {result.Age} {nameof(result.Location)}: {result.Location}");
        }
    }
}