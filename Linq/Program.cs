using System;
using System.Linq;
using Linq.Factories;

namespace Linq
{
    internal static class Program
    {
        private static void Main()
        {
            // Get the list of 100 people
            var listOfPeople = MakePeopleFactory.MakePeople();
            
            // listOfPeople.Aggregate("", (acc, p) => acc + p.LastName + ", ").Trim(' ', ',')
            // string.Join(", ", listOfPeople.Select(p => p.LastName))

            // Prevent console from closing when completed
            Console.ReadLine();
        }
    }
}