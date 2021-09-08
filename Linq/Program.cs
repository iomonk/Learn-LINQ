using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Factories;
using Linq.LinqMethods;
using Linq.Models;
using Linq.Service;

namespace Linq
{
    internal static class Program
    {
        // strings used throughout the Program Class
        private const string Choose = "Choose a Linq Method";
        private const string MenuLines = "---------------------------------------------------";
        private const string OriginalList = "The list before the any of the methods are applied";
        private static readonly string[] Menu = {"Option", "Method Name", "Type of Method", "Description"};

        private static void Main()
        {
            var listOfPeople = MakePeopleFactory.MakePeople().ToList();
            MainMenu();
            var choice = Console.ReadLine();
            DisplayOriginalList(listOfPeople);
            LoadUserChoice(choice, listOfPeople);
        }

        private static void MainMenu()
        {
            Console.WriteLine(Choose);
            Console.WriteLine(MenuLines);
            Console.WriteLine($"{Menu[0].PadRight(8, ' ')} {Menu[1].PadRight(13, ' ')} {Menu[2].PadRight(16, ' ')} {Menu[3]}");
            Console.WriteLine(MenuLines);

            foreach (var item in MethodOptionsFactory.ListOfMethods())
                Console.WriteLine($"{item.Id.PadRight(8, ' ')} {item.Name.PadRight(13, ' ')} {item.Type.PadRight(16, ' ')} {item.Description} ");
        }

        private static void DisplayOriginalList(IEnumerable<Person> people)
        {
            Console.WriteLine(OriginalList);

            foreach (var p in people) WriteLineService.WriteLine(p);
            Console.WriteLine();
        }

        private static void LoadUserChoice(string choice, IEnumerable<Person> people)
        {
            switch (choice)
            {
                case "1":
                    LinqOrderBy.OrderByMethod(people);
                    break;
                case "2":
                    LinqWhere.WhereMethod(people);
                    break;
                case "3":
                    LinqSum.SumMethod(people);
                    break;
                case "4":
                    LinqOfType.OfTypeMethod(people);
                    break;
                case "5":
                    LinqSelect.SelectMethod(people);
                    break;
                case "6":
                    Console.WriteLine("6");
                    break;
                case "7":
                    Console.WriteLine("7");
                    break;
                default:
                    Console.WriteLine("Make a choice");
                    break;
            }
        }
    }
}