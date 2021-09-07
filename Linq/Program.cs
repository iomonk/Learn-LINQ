using System;
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
            Console.WriteLine("Option\t Method Name\t Type of Method");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"1 \t OrderBy \t Deferred");
            Console.WriteLine($"2 \t Select \t Deferred");

            var choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    LinqOrderBy.OrderByMethod(listOfPeople);
                    break;
                case "2":
                    LinqWhere.WhereMethod(listOfPeople);
                    break;
                case "3":
                    Console.WriteLine("Make a choice");
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