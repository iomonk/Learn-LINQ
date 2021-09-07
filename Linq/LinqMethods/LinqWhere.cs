using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqWhere
    {
        // Filters a sequence of values based on a predicate (some given criteria).
        public static void WhereMethod(IEnumerable<Person> personList)
        {
            var personToList = personList.ToList();
            BeforeWhere(personToList);
            AfterWhere(personToList);
            AfterWhereWithAnd(personToList);
        }
        
        private static void BeforeWhere(IEnumerable<Person> personList)
        {
            Console.WriteLine("The list before 'Select' method is applied");
            foreach (var p in personList)
            {
                Console.WriteLine($"ID: {p.Id}\t First Name: {p.FirstName}\t Last Name: {p.LastName}\t Age: {p.Age} \t Location: {p.Location}");
            }
            Console.WriteLine();
        }
        
        private static void AfterWhere(IEnumerable<Person> personList)
        {
            Console.WriteLine("The list after 'Select' method is applied to filter ages greater than 50");
            var afterWhere = personList.Where(x => x.Age > 50).ToList();
            foreach (var p in afterWhere)
            {
                Console.WriteLine($"ID: {p.Id}\t First Name: {p.FirstName}\t Last Name: {p.LastName}\t Age: {p.Age} \t Location: {p.Location}");
            }
            Console.WriteLine();
        }
        
        private static void AfterWhereWithAnd(IEnumerable<Person> personList)
        {
            Console.WriteLine("The list after 'Select' method is applied to filter ages greater than 50 AND ID is less than 50");
            var afterWhere = personList.Where(x => x.Age > 50 && x.Id < 50).ToList();
            foreach (var p in afterWhere)
            {
                Console.WriteLine($"ID: {p.Id}\t First Name: {p.FirstName}\t Last Name: {p.LastName}\t Age: {p.Age} \t Location: {p.Location}");
            }
            Console.WriteLine();
        }
    }
}