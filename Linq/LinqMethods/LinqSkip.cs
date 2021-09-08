using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;
using Linq.Service;

namespace Linq.LinqMethods
{
    public static class LinqSkip
    {
        private const string AfterSkipStr =
            "The list after the 'Skip' method is applied. Skips displaying element 42 and any element prior.";

        private const string AfterSkipLastStr =
            "The list after the 'Skip' method is applied. Skips displaying the last 5 elements.";

        private const string AfterSkipWhileStr =
            "The list after the 'Skip' method is applied. Skips displaying elements with an age of 25. When an element matches the criteria, SkipWhile stops and the rest of the list is displayed.";

        public static void SkipMethod(IEnumerable<Person> personList)
        {
            var personToList = personList.ToList();
            AfterSkip(personToList);
            AfterSkipLast(personToList);
            AfterSkipWhile(personToList);
        }

        private static void AfterSkip(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterSkipStr);
            var result = personList.Skip(42);
            foreach (var p in result) WriteLineService.WriteLine(p);
            Console.WriteLine();
        }

        private static void AfterSkipLast(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterSkipLastStr);
            var result = personList.SkipLast(5);
            foreach (var p in result) WriteLineService.WriteLine(p);
            Console.WriteLine();
        }

        private static void AfterSkipWhile(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterSkipWhileStr);
            var result = personList.SkipWhile(x => x.Age >= 25);
            foreach (var p in result) WriteLineService.WriteLine(p);
        }
    }
}