using System;
using System.Collections.Generic;
using Linq.Models;

namespace Linq.Service
{
    // Gets the list of 100 random people from the MakePeopleFactory.
    public static class PersonListService
    {
        private static readonly string[] FirstNames =
        {
            "James", "Robert", "John", "Michael", "William", "David", "Richard", "Joseph", "Thomas", "Charles", "Chris",
            "Daniel", "Matthew", "Anthony", "Mark", "Donald", "Steven", "Paul", "Andrew", "Joshua", "Kenneth", "Kevin",
            "Brian", "George", "Edward", "Ronald", "Timothy", "Jason", "Jeffrey", "Ryan", "Jacob", "Gary", "Nicholas",
            "Eric", "Jonathan", "Stephen", "Larry", "Justin", "Scott", "Brandon", "Benjamin", "Samuel", "Gregory",
            "Frank", "Alex", "Raymond", "Patrick", "Jack", "Dennis", "Jerry", "Mary", "Patricia", "Jennifer", "Linda",
            "Elizabeth", "Barbara", "Susan", "Jessica", "Sarah", "Karen", "Nancy", "Lisa", "Betty", "Margaret",
            "Sandra", "Ashley", "Kimberly", "Emily", "Donna", "Michelle", "Dorothy", "Carol", "Amanda", "Melissa",
            "Deborah", "Stephanie", "Rebecca", "Sharon", "Laura", "Cynthia", "Kathleen", "Amy", "Shirley", "Angela",
            "Helen", "Anna", "Brenda", "Pamela", "Nicole", "Emma", "Samantha", "Katherine", "Christine", "Debra",
            "Rachel", "Catherine", "Carolyn", "Janet", "Ruth", "Maria"
        };

        private static readonly string[] LastNames =
        {
            "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez",
            "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson", "Thomas", "Taylor", "Moore", "Jackson", "Martin",
            "Baum", "Perez", "Thompson", "White", "Harris", "Sanchez", "Clark", "Ramirez", "Lewis", "Robinson",
            "Walker",
            "Young", "Allen", "King", "Wright", "Scott", "Torres", "Nguyen", "Hill", "Flores", "Green", "Adams",
            "Nelson", "Baker", "Hall", "Rivera", "Campbell", "Mitchell", "Carter", "King", "Smith", "Johnson",
            "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez", "Hernandez", "Lopez",
            "Gonzalez", "Wilson", "Anderson", "Thomas", "Taylor", "Moore", "Jackson", "Martin", "Hampton", "Perez",
            "Thompson", "White", "Harris", "Sanchez", "Clark", "Ramirez", "Lewis", "Robinson", "Walker", "Young",
            "Allen", "King", "Wright", "Scott", "Torres", "Nguyen", "Hill", "Flores", "Green", "Adams", "Nelson",
            "Baker", "Hall", "Rivera", "Campbell", "Mitchell", "Carter", "King", "Earley", "Falkner"
        };

        private static readonly string[] Locations =
        {
            "New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "Philadelphia", "San Antonio", "San Diego",
            "Dallas", "San Jose", "Austin", "Fort Worth", "Jacksonville", "Columbus", "Charlotte", "Indianapolis",
            "San Francisco", "Seattle", "Denver", "Washington", "Boston", "El Paso", "Nashville", "Detroit",
            "Las Vegas", "New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "Philadelphia", "San Antonio",
            "San Diego", "Dallas", "San Jose", "Austin", "Fort Worth", "Jacksonville", "Columbus", "Charlotte",
            "Indianapolis", "San Francisco", "Seattle", "Denver", "Washington", "Boston", "El Paso", "Nashville",
            "Detroit", "Las Vegas", "New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "Philadelphia",
            "San Antonio", "San Diego", "Dallas", "San Jose", "Austin", "Fort Worth", "Jacksonville", "Columbus",
            "Charlotte", "Indianapolis", "San Francisco", "Seattle", "Denver", "Washington", "Boston", "El Paso",
            "Nashville", "Detroit", "Las Vegas", "New York", "Los Angeles", "Chicago", "Houston", "Phoenix",
            "Philadelphia", "San Antonio", "San Diego", "Dallas", "San Jose", "Austin", "Fort Worth", "Jacksonville",
            "Columbus", "Charlotte", "Indianapolis", "San Francisco", "Seattle", "Denver", "Washington", "Boston",
            "El Paso", "Nashville", "Detroit", "Las Vegas", "Salt Lake City"
        };

        private static readonly Random Rnd = new();

        public static IEnumerable<Person> MakePeople()
        {
            var listOfPeople = new List<Person>();

            for (var i = 1; i <= 100; i++)
            {
                var person = new Person
                {
                    Id = i,
                    FirstName = FirstNames[Rnd.Next(0, FirstNames.Length)],
                    LastName = LastNames[Rnd.Next(0, LastNames.Length)],
                    Age = Rnd.Next(0, 100),
                    Location = Locations[Rnd.Next(0, Locations.Length)]
                };
                listOfPeople.Add(person);
            }

            return listOfPeople;
        }
    }
}