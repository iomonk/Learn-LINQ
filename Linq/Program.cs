using System;
using System.Linq;
using Linq.Factories;
using Linq.LinqMethods;

namespace Linq
{
    internal static class Program
    {
        private static void Main()
        {
            // Gets the list of 100 random people from the MakePeopleFactory.
            var listOfPeople = MakePeopleFactory.MakePeople();
            
            Console.WriteLine("Choose a Linq Method");
            Console.WriteLine($"{"Option".PadRight(8, ' ')} {"Method Name".PadRight(13, ' ')} {"Type of Method".PadRight(17, ' ')}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"{"1".PadRight(8, ' ')} {"OrderBy".PadRight(13, ' ')} {"Deferred".PadRight(17, ' ')}");
            Console.WriteLine($"{"2".PadRight(8, ' ')} {"Where".PadRight(13, ' ')} {"Deferred".PadRight(17, ' ')}");
            Console.WriteLine($"{"3".PadRight(8, ' ')} {"Sum".PadRight(13, ' ')} {"Iterative".PadRight(17, ' ')}");

            var choice = Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine("The list before the any of the methods are applied");
            var personList = listOfPeople.ToList();
            foreach (var p in personList)
            {
                Console.WriteLine($"ID: {p.Id}\t First Name: {p.FirstName}\t Last Name: {p.LastName}\t Age: {p.Age} \t Location: {p.Location}");
            }
            Console.WriteLine();
            
            switch (choice)
            {
                case "1":
                    LinqOrderBy.OrderByMethod(personList);
                    break;
                case "2":
                    LinqWhere.WhereMethod(personList);
                    break;
                case "3":
                    LinqSum.SumMethod(personList);
                    break;
                case "4":
                    Console.WriteLine("Make a choice");
                    break;
                case "5":
                    Console.WriteLine("Make a choice");
                    break;
                case "6":
                    Console.WriteLine("Make a choice");
                    break;
                case "7":
                    Console.WriteLine("Make a choice");
                    break;
                default:
                    Console.WriteLine("Make a choice");
                    break;
            }
        }
    }
}