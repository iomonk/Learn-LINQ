using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqMin
    {
        private const string AfterMinStr = "The list after the 'Min' method is applied. Returns the youngest age in the list.";

        public static void MinMethod(IEnumerable<Person> personList)
        {
            AfterMin(personList);
        }

        private static void AfterMin(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterMinStr);
            var result = personList.Min(x => x.Age);
            Console.WriteLine(result);
        }
    }
}