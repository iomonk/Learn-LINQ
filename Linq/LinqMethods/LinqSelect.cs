using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqSelect
    {
        private const string AfterSelectStr =
            "The list after the 'Select' method is applied. Creates a new list of your selected elements. In this case LastName, FirstName";

        public static void SelectMethod(IEnumerable<Person> personList)
        {
            AfterLastAndFirstNameSelect(personList);
        }

        private static void AfterLastAndFirstNameSelect(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterSelectStr);
            var result = personList.Select(x => $"{x.LastName}, {x.FirstName}");

            foreach (var p in result) Console.WriteLine(p);
            Console.WriteLine();
        }

        // Using a function method group instead of the standard lambda. Does the same thing as above.
        private static void AfterLastAndFirstNameSelectMethodGroup(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterSelectStr);
            var result = personList.Select(LastAndFirstNameFunction);

            foreach (var p in result) Console.WriteLine(p);
            Console.WriteLine();
        }

        private static string LastAndFirstNameFunction(Person person)
        {
            return $"{person.LastName}, {person.FirstName}";
        }
    }
}