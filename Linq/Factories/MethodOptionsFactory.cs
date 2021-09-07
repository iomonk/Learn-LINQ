using Linq.Models;

namespace Linq.Factories
{
    public static class MethodOptionsFactory
    {
        public static MethodOptions OrderByOption()
        {
            return new MethodOptions()
            {
                Id = "1",
                Name = "OrderBy",
                Type = "Deferred",
                Description = "Sorts the elements of a sequence in a desired order."
            };
        }
        
        public static MethodOptions WhereOption()
        {
            return new MethodOptions()
            {
                Id = "2",
                Name = "Where",
                Type = "Deferred",
                Description = "Filters a sequence of values based on a predicate/criteria."
            };
        }
        
        public static MethodOptions SumOption()
        {
            return new MethodOptions()
            {
                Id = "3",
                Name = "Sum",
                Type = "Iterative",
                Description = "Computes the sum of a sequence of numeric values."
            };
        }
        
        public static MethodOptions OfTypeOption()
        {
            return new MethodOptions()
            {
                Id = "4",
                Name = "OfType",
                Type = "Deferred",
                Description = "Filters the elements of an IEnumerable based on a specified type (string, int, Person, etc...)"
            };
        }
    }
}