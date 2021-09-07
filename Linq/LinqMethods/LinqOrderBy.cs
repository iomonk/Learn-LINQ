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
            
            Console.WriteLine("OrderBy - Sorts the elements of a sequence in ascending order.");
            Console.WriteLine("OrderByDescending - Sorts the elements of a sequence in descending order.");
            Console.WriteLine();
            
            AfterOrderBy(personListToList);
            AfterOrderByDescending(personListToList);
            AfterOrderByChained(personListToList);
            AfterOrderByDescendingChained(personListToList);
        }
        
        private static void AfterOrderBy(IEnumerable<Person> personList)
        {
            Console.WriteLine("The list after the 'OrderBy' method is applied. Sorts the list by Last Name in ascending order.");
            var persons = personList.OrderBy(x => x.LastName).ToList();
            foreach (var p in persons)
            {
                Console.WriteLine($"ID: {p.Id}\t First Name: {p.FirstName}\t Last Name: {p.LastName}\t Age: {p.Age} \t Location: {p.Location}");
            }
            Console.WriteLine();
        }
        
        private static void AfterOrderByDescending(IEnumerable<Person> personList)
        {
            Console.WriteLine("The list after the 'OrderByDescending' method is applied. Sorts the list by Last Name in descending order.");
            var persons = personList.OrderByDescending(x => x.LastName).ToList();
            foreach (var p in persons)
            {
                Console.WriteLine($"ID: {p.Id}\t First Name: {p.FirstName}\t Last Name: {p.LastName}\t Age: {p.Age} \t Location: {p.Location}");
            }
            Console.WriteLine();
        }
        
        private static void AfterOrderByChained(IEnumerable<Person> personList)
        {
            Console.WriteLine("The list after the 'OrderBy' method with a chained 'ThenBy' method is applied. Sorts the list by Last Name in ascending order. Then sorts the First names in ascending order while keeping the last names in order.");
            var persons = personList.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
            foreach (var p in persons)
            {
                Console.WriteLine($"ID: {p.Id}\t First Name: {p.FirstName}\t Last Name: {p.LastName}\t Age: {p.Age} \t Location: {p.Location}");
            }
            Console.WriteLine();
        }
        
        private static void AfterOrderByDescendingChained(IEnumerable<Person> personList)
        {
            Console.WriteLine("The list after the 'OrderByDescending' method with a chained 'ThenByDescending' method is applied. Sorts the list by Last Name in descending order. Then sorts the First names in descending order while keeping the last names in order.");
            var persons = personList.OrderByDescending(x => x.LastName).ThenByDescending(x => x.FirstName).ToList();
            foreach (var p in persons)
            {
                Console.WriteLine($"ID: {p.Id}\t First Name: {p.FirstName}\t Last Name: {p.LastName}\t Age: {p.Age} \t Location: {p.Location}");
            }
            Console.WriteLine();
        }
    }
}