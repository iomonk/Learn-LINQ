using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;
using Linq.Service;

namespace Linq.LinqMethods
{
    public static class LinqOfType
    {
        // strings used throughout the LinqOfType Class
        private const string AfterOfTypeStr = "The list After the 'OfType' method is applied. The list is unchanged because all objects are already of type 'Person'";
        private const string AfterOfBetterExampleStr = "An object is created with the following items { 1, \"3\", \"Some other string\", 10 }";
        
        
        public static void OfTypeMethod(IEnumerable<Person> personList)
        {
            var personToList = personList.ToList();
            AfterOfType(personToList);
            AfterOfBetterExample();
        }
        
        private static void AfterOfType(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterOfTypeStr);
            var afterOfType = personList.OfType<Person>();

            foreach (var p in afterOfType)
            {
                WriteLineService.WriteLine(p);
            }
            Console.WriteLine();
        }
        
        private static void AfterOfBetterExample()
        {
            Console.WriteLine(AfterOfBetterExampleStr);
            var array = new object[] {1, "3", "Some other string", 10};
            
            Console.WriteLine("Running 'OfType<string>' on the object will only grab '3' and 'Some other string'");
            var afterOfType = array.OfType<string>();
            
            foreach (var item in afterOfType)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}