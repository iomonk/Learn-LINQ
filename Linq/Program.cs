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
        private static readonly string[] Menu = new[] {"Option", "Method Name", "Type of Method", "Description"};
        private const string OriginalList = "The list before the any of the methods are applied";

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
            Console.WriteLine($"{MethodOptionsFactory.OrderByOption().Id.PadRight(8, ' ')} {MethodOptionsFactory.OrderByOption().Name.PadRight(13, ' ')} {MethodOptionsFactory.OrderByOption().Type.PadRight(16, ' ')} {MethodOptionsFactory.OrderByOption().Description} ");
            Console.WriteLine($"{MethodOptionsFactory.WhereOption().Id.PadRight(8, ' ')} {MethodOptionsFactory.WhereOption().Name.PadRight(13, ' ')} {MethodOptionsFactory.WhereOption().Type.PadRight(16, ' ')} {MethodOptionsFactory.WhereOption().Description} ");
            Console.WriteLine($"{MethodOptionsFactory.SumOption().Id.PadRight(8, ' ')} {MethodOptionsFactory.SumOption().Name.PadRight(13, ' ')} {MethodOptionsFactory.SumOption().Type.PadRight(16, ' ')} {MethodOptionsFactory.SumOption().Description} ");
        }
        
        private static void DisplayOriginalList(IEnumerable<Person> people)
        {
            Console.WriteLine(OriginalList);
            var personList = people.ToList();
            foreach (var p in personList)
            {
                WriteLineService.WriteLine(p);
            }
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