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
            }
        };

        public static List<MethodOptions> ListOfMethods()
        {
            return MethodOptionsList;
        }
    }
}