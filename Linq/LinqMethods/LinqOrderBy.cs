using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqOrderBy
    {
        public static void OrderByMethod(IEnumerable<Person> personList)
        {
            var personListToList = personList.ToList();
            BeforeOrderBy(personListToList);
            AfterOrderBy(personListToList);
        }

        private static void BeforeOrderBy(IEnumerable<Person> personList)
        {
            Console.WriteLine("Before 'OrderBy' method is applied");
            foreach (var p in personList)
            {
                Console.WriteLine($"ID: {p.Id}\t First Name: {p.FirstName}\t Last Name: {p.LastName}\t Age: {p.Age} \t Location: {p.Location}");
            }
            Console.WriteLine();
        }
        
        private static void AfterOrderBy(IEnumerable<Person> personList)
        {
            Console.WriteLine("After 'OrderBy' method is applied");
            var persons = personList.OrderBy(x => x.LastName).ToList();
            foreach (var p in persons)
            {
                Console.WriteLine($"ID: {p.Id}\t First Name: {p.FirstName}\t Last Name: {p.LastName}\t Age: {p.Age} \t Location: {p.Location}");
            }
        }
    }
}