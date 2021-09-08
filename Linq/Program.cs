using System;
using System.Collections.Generic;
using System.Linq;
using Linq.LinqMethods;
using Linq.Models;
using Linq.Service;

namespace Linq
{
    internal static class Program
    {
        private const string Choose = "Choose a Linq Method";
        private const string MenuLines = "---------------------------------------------------";
        private const string OriginalList = "The list before the any of the methods are applied";
        private const string Exit = "Press any key to exit.";
        private static readonly string[] Menu = {"Option", "Method Name", "Type of Method", "Description"};

        private static void Main()
        {
            var listOfPeople = PersonListService.MakePeople().ToList();
            MainMenu();
            var choice = int.Parse(Console.ReadLine() ?? string.Empty);
            DisplayOriginalList(listOfPeople);
            LoadUserChoice(choice, listOfPeople);
            Console.WriteLine(Exit);
            Console.ReadLine();
        }

        private static void MainMenu()
        {
            Console.WriteLine(Choose);
            Console.WriteLine(MenuLines);
            Console.WriteLine(
                $"{Menu[0].PadRight(8, ' ')} {Menu[1].PadRight(13, ' ')} {Menu[2].PadRight(16, ' ')} {Menu[3]}");
            Console.WriteLine(MenuLines);

            foreach (var item in LinqMethodListService.ListOfMethods())
                Console.WriteLine(
                    $"{item.Id.PadRight(8, ' ')} {item.Name.PadRight(13, ' ')} {item.Type.PadRight(16, ' ')} {item.Description} ");
        }

        private static void DisplayOriginalList(IEnumerable<Person> people)
        {
            Console.WriteLine(OriginalList);

            foreach (var p in people) WriteLineService.WriteLine(p);
            Console.WriteLine();
        }

        private static void LoadUserChoice(int choice, IEnumerable<Person> people)
        {
            switch (choice)
            {
                case 1:
                    LinqOrderBy.OrderByMethod(people);
                    break;
                case 2:
                    LinqWhere.WhereMethod(people);
                    break;
                case 3:
                    LinqSum.SumMethod(people);
                    break;
                case 4:
                    LinqOfType.OfTypeMethod(people);
                    break;
                case 5:
                    LinqSelect.SelectMethod(people);
                    break;
                case 6:
                    LinqAverage.AverageMethod(people);
                    break;
                case 7:
                    LinqCount.CountMethod(people);
                    break;
                case 8:
                    LinqMax.MaxMethod(people);
                    break;
                case 9:
                    LinqMin.MinMethod(people);
                    break;
                case 10:
                    LinqAll.AllMethod(people);
                    break;
                case 11:
                    LinqAny.AnyMethod(people);
                    break;
                case 12:
                    LinqToDictionary.ToDictionaryMethod(people);
                    break;
                case 13:
                    LinqElementAt.ElementAtMethod(people);
                    break;
                case 14:
                    LinqFirst.FirstMethod(people);
                    break;
                case 15:
                    LinqFirstOrDefault.FirstOrDefaultMethod(people);
                    break;
                case 16:
                    LinqLast.LastMethod(people);
                    break;
                case 17:
                    LinqLastOrDefault.LastOrDefaultMethod(people);
                    break;
                case 18:
                    Console.WriteLine("xxx");
                    break;
                case 19:
                    Console.WriteLine("xxx");
                    break;
                case 20:
                    Console.WriteLine("xxx");
                    break;
                default:
                    Console.WriteLine("Make a choice");
                    break;
            }
        }
    }
}