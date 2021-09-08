using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqFirst
    {
        private const string AfterFirstStr =
            "The list after the 'First' method is applied. Will return the first element in the list.";

        public static void FirstMethod(IEnumerable<Person> personList)
        {
            AfterFirst(personList);
        }

        private static void AfterFirst(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterFirstStr);
            var result = personList.First();
            Console.WriteLine(
                $"{nameof(result.Id)}: {result.Id} {nameof(result.FirstName)}: {result.FirstName} {nameof(result.LastName)}: {result.LastName}: {nameof(result.Age)}: {result.Age} {nameof(result.Location)}: {result.Location}");
        }
    }
}