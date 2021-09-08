using System.Collections.Generic;
using Linq.Models;

namespace Linq.Factories
{
    public static class MethodOptionsFactory
    {
        private static readonly List<MethodOptions> MethodOptionsList = new()
        {
            new MethodOptions
            {
                Id = "1",
                Name = "OrderBy",
                Type = "Deferred",
                Description = "Sorts the elements of a sequence in a desired order."
            },
            new MethodOptions
            {
                Id = "2",
                Name = "Where",
                Type = "Deferred",
                Description = "Filters a sequence of values based on a predicate/criteria."
            },
            new MethodOptions
            {
                Id = "3",
                Name = "Sum",
                Type = "Iterative",
                Description = "Computes the sum of a sequence of numeric values."
            },
            new MethodOptions
            {
                Id = "4",
                Name = "OfType",
                Type = "Deferred",
                Description =
                    "Filters the elements of an IEnumerable based on a specified type (string, int, Person, etc...)"
            },
            new MethodOptions
            {
                Id = "5",
                Name = "Select",
                Type = "Deferred",
                Description = "Projects each element of a sequence into a new form."
            },
            new MethodOptions
            {
                Id = "6",
                Name = "Average",
                Type = "Iterative",
                Description = "Computes the average of a sequence of numeric values."
            },
            new MethodOptions
            {
                Id = "7",
                Name = "Count",
                Type = "Iterative",
                Description = "Returns the number of elements in a sequence."
            },
            new MethodOptions
            {
                Id = "8",
                Name = "Max",
                Type = "Iterative",
                Description = "Returns the maximum value in a sequence of values."
            },
            new MethodOptions
            {
                Id = "9",
                Name = "Min",
                Type = "Iterative",
                Description = "Returns the minimum value in a sequence of values."
            },
            new MethodOptions
            {
                Id = "10",
                Name = "All",
                Type = "Iterative",
                Description = "Determines whether all elements of a sequence satisfy a condition."
            },
            new MethodOptions
            {
                Id = "11",
                Name = "Any",
                Type = "Iterative",
                Description = "Determines whether any element of a sequence exists or satisfies a condition."
            },
            new MethodOptions
            {
                Id = "12",
                Name = "ToDictionary",
                Type = "Deferred",
                Description = "Creates a Dictionary<TKey,TValue> from an IEnumerable<T>."
            },
            new MethodOptions
            {
                Id = "13",
                Name = "ElementAt",
                Type = "Deferred",
                Description = "Returns the element at a specified index in a sequence."
            },
            new MethodOptions
            {
                Id = "14",
                Name = "First",
                Type = "Iterative",
                Description = "Returns the first element of a sequence."
            },
            new MethodOptions
            {
                Id = "15",
                Name = "FirstOrDefault",
                Type = "Iterative",
                Description = "Returns the first element of a sequence, or a default value if no element is found."
            },
            new MethodOptions
            {
                Id = "16",
                Name = "Last",
                Type = "Iterative",
                Description = "Returns the last element of a sequence."
            },
            new MethodOptions
            {
                Id = "17",
                Name = "LastOrDefault",
                Type = "Iterative",
                Description = "Returns the last element of a sequence, or a default value if no element is found."
            },
            new MethodOptions
            {
                Id = "18",
                Name = "xxx",
                Type = "xxx",
                Description = "xxx"
            },
            new MethodOptions
            {
                Id = "19",
                Name = "xxx",
                Type = "xxx",
                Description = "xxx"
            },
            new MethodOptions
            {
                Id = "20",
                Name = "xxx",
                Type = "xxx",
                Description = "xxx"
            }
        };

        public static List<MethodOptions> ListOfMethods()
        {
            return MethodOptionsList;
        }
    }
}