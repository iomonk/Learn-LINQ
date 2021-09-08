using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqToDictionary
    {
        private const string AfterToDictionaryStr =
            "The list after the 'ToDictionary' method is applied. Creates a dictionary with a key (Id) value (LastName) pair.";

        public static void ToDictionaryMethod(IEnumerable<Person> personList)
        {
            AfterToDictionary(personList);
        }

        private static void AfterToDictionary(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterToDictionaryStr);
            var result = personList.ToDictionary(x => x.Id, x => x.LastName);
            foreach (var (key, value) in result) Console.WriteLine($"{key}: {value}");
        }
    }
}