using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqLastOrDefault
    {
        private const string AfterLastOrDefaultStr = "The list after the 'LastOrDefault' method is applied.";
        private const string ErrorStr = "There is no element with an age less than 0";

        public static void LastOrDefaultMethod(IEnumerable<Person> personList)
        {
            AfterLastOrDefault(personList);
        }

        private static void AfterLastOrDefault(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterLastOrDefaultStr);
            var result = personList.LastOrDefault(x => x.Age < 0);
            if (result == null) Console.WriteLine($"{ErrorStr}");
        }
    }
}