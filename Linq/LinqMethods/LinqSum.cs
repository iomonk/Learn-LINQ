using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqSum
    {
        private const string AfterAgesStr =
            "The list after the 'Sum' method is applied. Shows the sum of all the ages.";

        private const string AfterIdsStr = "The list after the 'Sum' method is applied. Shows the sum of all the Ids.";

        public static void SumMethod(IEnumerable<Person> personList)
        {
            var personToList = personList.ToList();
            AfterAgesSum(personToList);
            AfterIdsSum(personToList);
        }

        private static void AfterAgesSum(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterAgesStr);
            var summedAges = personList.Sum(x => x.Age);
            Console.WriteLine(summedAges);
        }

        private static void AfterIdsSum(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterIdsStr);
            var summedAges = personList.Sum(x => x.Id);
            Console.WriteLine(summedAges);
        }
    }
}