using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqFirstOrDefault
    {
        private const string AfterFirstOrDefaultStr =
            "The list after the 'FirstOrDefault' method is applied. Will return the first element in the list. If no element is found it will return null.";

        private const string ErrorStr = "There is no element with an age less than 0";

        public static void FirstOrDefaultMethod(IEnumerable<Person> personList)
        {
            AfterFirstOrDefault(personList);
        }

        private static void AfterFirstOrDefault(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterFirstOrDefaultStr);
            var result = personList.FirstOrDefault(x => x.Age < 0);
            if (result == null) Console.WriteLine($"{ErrorStr}");
        }
    }
}