using System;
using System.Collections.Generic;
using Linq.Models;

namespace Linq.LinqMethods
{
    public static class LinqTemplate
    {
        private const string AfterTemplateStr = "The list after the 'Template' method is applied.";

        public static void TemplateMethod(IEnumerable<Person> personList)
        {
            AfterTemplate(personList);
        }

        private static void AfterTemplate(IEnumerable<Person> personList)
        {
            Console.WriteLine(AfterTemplateStr);
            var result = personList;
            Console.WriteLine(result);
        }
    }
}