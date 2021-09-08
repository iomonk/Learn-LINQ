using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;
using Linq.Service;

namespace Linq.LinqMethods
{
    public static class LinqWhere
    {
        private const string AfterWhereStr =
            "The list after the 'Select' method is applied to filter ages greater than 50";

        private const string AfterWhereWithAndStr =
            "The list after the 'Select' method is applied to filter ages greater than 50 AND ID is less than 50";

        public static void WhereMethod(IEnumerable<Person> personList)
        {
            var personToList = personList.ToList();
            AfterWhere(personToList);
            AfterWhereWithAnd(personToList);
        }

        private static void AfterWhere(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterWhereStr);
            var afterWhere = personList.Where(x => x.Age > 50);

            foreach (var p in afterWhere) WriteLineService.WriteLine(p);
            Console.WriteLine();
        }

        private static void AfterWhereWithAnd(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterWhereWithAndStr);
            var afterWhere = personList.Where(x => x.Age > 50 && x.Id < 50);

            foreach (var p in afterWhere) WriteLineService.WriteLine(p);
            Console.WriteLine();
        }
    }
}