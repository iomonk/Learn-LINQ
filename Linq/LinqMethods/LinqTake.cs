using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;
using Linq.Service;

namespace Linq.LinqMethods
{
    public static class LinqTake
    {
        private const string AfterTakeStr = "The list after the 'Take' method is applied. Takes and displays only the first 10 elements";
        private const string AfterTakeLastStr = "The list after the 'Take' method is applied. Takes and displays only the last 5 elements.";
        private const string AfterTakeWhileStr = "The list after the 'Take' method is applied. Takes and displays all elements until the condition is met.";

        public static void TakeMethod(IEnumerable<Person> personList)
        {
            var personToList = personList.ToList();
            AfterTake(personToList);
            AfterTakeLast(personToList);
            AfterTakeWhile(personToList);
        }

        private static void AfterTake(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterTakeStr);
            var result = personList.Take(10);
            foreach (var p in result) WriteLineService.WriteLine(p);
            Console.WriteLine();
        }
        
        private static void AfterTakeLast(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterTakeLastStr);
            var result = personList.TakeLast(5);
            foreach (var p in result) WriteLineService.WriteLine(p);
            Console.WriteLine();
        }
        
        private static void AfterTakeWhile(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterTakeWhileStr);
            var result = personList.TakeWhile(x => x.Age >= 25);
            foreach (var p in result) WriteLineService.WriteLine(p);
        }
    }
}