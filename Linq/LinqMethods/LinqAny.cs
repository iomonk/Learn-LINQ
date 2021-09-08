using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqAny
    {
        private const string AfterAnyStr =
            "The list after the 'Any' method is applied. Will check to see if any ages are greater than 0";

        public static void AnyMethod(IEnumerable<Person> personList)
        {
            AfterAny(personList);
        }

        private static void AfterAny(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterAnyStr);
            var result = personList.Any(x => x.Age > 0);
            Console.WriteLine(result);
        }
    }
}