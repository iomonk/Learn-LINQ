using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;
using Linq.Service;

namespace Linq.LinqMethods
{
    public static class LinqOrderBy
    {
        private const string AfterOrderByStr =
            "The list after the 'OrderBy' method is applied. Sorts the list by Last Name in ascending order.";

        private const string AfterOrderByDescStr =
            "The list after the 'OrderByDescending' method is applied. Sorts the list by Last Name in descending order.";

        private const string AfterOrderByChainedStr =
            "The list after the 'OrderBy' method with a chained 'ThenBy' method is applied. Sorts the list by Last Name in ascending order. Then sorts the First names in ascending order while keeping the last names in order.";

        private const string AfterOrderByDescChainedStr =
            "The list after the 'OrderByDescending' method with a chained 'ThenByDescending' method is applied. Sorts the list by Last Name in descending order. Then sorts the First names in descending order while keeping the last names in order.";

        public static void OrderByMethod(IEnumerable<Person> personList)
        {
            var personListToList = personList.ToList();
            AfterOrderBy(personListToList);
            AfterOrderByDescending(personListToList);
            AfterOrderByChained(personListToList);
            AfterOrderByDescendingChained(personListToList);
        }

        private static void AfterOrderBy(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterOrderByStr);
            var persons = personList.OrderBy(x => x.LastName);

            foreach (var p in persons) WriteLineService.WriteLine(p);
            Console.WriteLine();
        }

        private static void AfterOrderByDescending(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterOrderByDescStr);
            var persons = personList.OrderByDescending(x => x.LastName);

            foreach (var p in persons) WriteLineService.WriteLine(p);
            Console.WriteLine();
        }

        private static void AfterOrderByChained(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterOrderByChainedStr);
            var persons = personList.OrderBy(x => x.LastName).ThenBy(x => x.FirstName);

            foreach (var p in persons) WriteLineService.WriteLine(p);
            Console.WriteLine();
        }

        private static void AfterOrderByDescendingChained(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterOrderByDescChainedStr);
            var persons = personList.OrderByDescending(x => x.LastName).ThenByDescending(x => x.FirstName);

            foreach (var p in persons) WriteLineService.WriteLine(p);
            Console.WriteLine();
        }
    }
}