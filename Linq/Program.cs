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
        private const string MenuLines = "-----------------------------------------------------";
        private const string OriginalList = "The list before the any of the methods are applied";
        private const string EnterOptions = "Enter option or 'q' to quit: ";
        private const string FinalMessage = "Scroll up to see the results. Press Enter to go back to the main menu.";
        private static readonly string[] Menu = {"Option", "Method Name", "Type of Method", "Description"};

        private static void Main()
        {
            var isQuit = false;
            var methods = LinqMethodListService.ListOfMethods();
            var listOfPeople = PersonListService.MakePeople().ToList();

            do
            {
                var choice = MainMenu(methods);
                switch (choice)
                {
                    case -1:
                        Console.WriteLine("Exiting");
                        isQuit = true;
                        break;
                    case 0:
                        continue;
                    default:
                        DisplayOriginalList(listOfPeople);
                        LoadUserChoice(choice, listOfPeople);
                        Console.WriteLine(FinalMessage);
                        Console.ReadLine();
                        break;
                }
            } while (!isQuit);
        }

        private static int MainMenu(List<MethodOptions> methods)
        {
            Console.WriteLine(Choose);
            Console.WriteLine(MenuLines);
            Console.WriteLine(
                $"{Menu[0].PadRight(8, ' ')} {Menu[1].PadRight(15, ' ')} {Menu[2].PadRight(16, ' ')} {Menu[3]}");
            Console.WriteLine(MenuLines);

            foreach (var item in methods)
                Console.WriteLine(
                    $"{item.Id.PadRight(8, ' ')} {item.Name.PadRight(15, ' ')} {item.Type.PadRight(16, ' ')} {item.Description} ");

            Console.Write(EnterOptions);

            var option = Console.ReadLine();
            if (option != null && option.ToLower() == "q") return -1;

            return int.TryParse(option ?? string.Empty, out var choice)
                   && choice > 0
                   && choice <= methods.Count
                ? choice
                : 0;
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
                    LinqReverse.ReverseMethod(people);
                    break;
                case 19:
                    LinqSkip.SkipMethod(people);
                    break;
                case 20:
                    LinqTake.TakeMethod(people);
                    break;
                case 21:
                    LinqDistinct.DistinctMethod(people);
                    break;
                default:
                    Console.WriteLine("Make a valid choice");
                    break;
            }
        }
    }
}