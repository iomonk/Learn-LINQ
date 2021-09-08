using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;
using Linq.Service;

namespace Linq.LinqMethods
{
    public static class LinqReverse
    {
        private const string AfterReverseStr =
            "The list after the 'Reverse' method is applied. Reverses the order of the list.";

        public static void ReverseMethod(IEnumerable<Person> personList)
        {
            AfterReverse(personList);
        }

        private static void AfterReverse(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterReverseStr);
            var result = personList.Reverse();
            foreach (var p in result) WriteLineService.WriteLine(p);
        }
    }
}