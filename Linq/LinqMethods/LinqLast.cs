using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqLast
    {
        private const string AfterLastStr = "The list after the 'Last' method is applied. Will return the last element in the list.";

        public static void LastMethod(IEnumerable<Person> personList)
        {
            AfterLast(personList);
        }

        private static void AfterLast(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterLastStr);
            var result = personList.Last();
            Console.WriteLine($"{nameof(result.Id)}: {result.Id} {nameof(result.FirstName)}: {result.FirstName} {nameof(result.LastName)}: {result.LastName}: {nameof(result.Age)}: {result.Age} {nameof(result.Location)}: {result.Location}");
        }
    }
}