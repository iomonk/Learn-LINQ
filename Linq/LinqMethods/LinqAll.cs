using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqAll
    {
        private const string AfterAllStr = "The list after the 'All' method is applied. Will check to see if all ages are greater than 0";

        public static void AllMethod(IEnumerable<Person> personList)
        {
            AfterAll(personList);
        }

        private static void AfterAll(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterAllStr);
            var result = personList.All(x => x.Age > 0);
            Console.WriteLine(result);
        }
    }
}