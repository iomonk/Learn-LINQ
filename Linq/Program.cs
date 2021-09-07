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
            
            // OrderBy - Sorts the elements of a sequence in ascending order.
            LinqOrderBy.OrderByMethod(listOfPeople);
        }
    }
}