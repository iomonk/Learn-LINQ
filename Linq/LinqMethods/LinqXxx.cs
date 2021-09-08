using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqXxx
    {
        private const string AfterXxxStr = "The list after the 'Xxx' method is applied.";

        public static void XxxMethod(IEnumerable<Person> personList)
        {
            AfterXxx(personList);
        }

        private static void AfterXxx(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterXxxStr);
            var result = personList;
            Console.WriteLine(result);
        }
    }
}