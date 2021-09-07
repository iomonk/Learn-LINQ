using System;
using Linq.Models;

namespace Linq.Service
{
    public static class WriteLineService
    {
        public static void WriteLine(Person p)
        {
            Console.WriteLine($"{nameof(p.Id)}: {p.Id.ToString().PadRight(5, ' ')} {nameof(p.FirstName)}: {p.FirstName.PadRight(12, ' ')} {nameof(p.LastName)}: {p.LastName.PadRight(12, ' ')} {nameof(p.Age)}: {p.Age.ToString().PadRight(5, ' ')} {nameof(p.Location)}: {p.Location}");
        }
    }
}