﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._8._9
{
    class Students
    {
        // James - I see you have a Students class here,  to refactor, in this class I would only have like 
        // THREE properties, one for Name, Food, and Town.  this will hold this data for an individual student. 
        // then in say the Program class;  Consider creating a new list of Student, so like List<Student>();
        // this will keep your code WAY more organized.
        List<string> studentList = new List<string>()
        {
            "Becky",
            "Tom",
            "Jason",
            "Zack",
            "James",
            "Andrew",
            "Jake",
            "Rachel",
            "Katie",
            "Grace",
            "Kim",
            "Nerms",
            "Tianna",
            "Jen",
            "Aaron",
            "Krissy",
            "Krista",
            "Andy",
            "Sammy",
            "Matt"
        };

        List<string> studentHome = new List<string>()
        {
            "Detroit",
            "Phoenix",
            "Warren",
            "Troy",
            "Harper Woods",
            "Pontiac",
            "Auburn Hills",
            "Buffalo",
            "New York City",
            "Windsor",
            "Hamtramck",
            "Melvindale",
            "Lincoln Park",
            "Austin",
            "Boston",
            "Dallas",
            "Madison Heights",
            "Grosse Pointe",
            "Huntington Woods",
            "Ferndale"
        };

        List<string> studentFood = new List<string>()
        {
            "Burgers",
            "Pizza",
            "Ramen",
            "Lo Mein",
            "Grilled Cheese",
            "Yogurt",
            "Curry",
            "Fried Chicken",
            "Ice Cream",
            "Mozzarella Sticks",
            "Spaghetti",
            "Ravioli",
            "Chicken Marsala",
            "Pierogi",
            "Sauerkraut",
            "Falafel",
            "Calzones",
            "Submarine Sandwiches",
            "French Fries",
            "Butter Chicken",
        };
            
        // James - I like your extensive use of methods here! good job.
        public string GetStudent(int convertedUserNumber)
        {
            // James - what happens if we enter a negative numer or something greater than the Count of this list? 
            // consider hadling errors in this program.
            Console.Write($"You have chosen {studentList[convertedUserNumber - 1]}. What would you like to know more about? Enter home or food: ");
            var outputKnowMore = Console.ReadLine();

            return outputKnowMore;
        }

        public void GetInfo(int convertedUserNumber, string outputKnowMore)
        {
            var repeat = true;

            while (repeat)
            {
                if (outputKnowMore.StartsWith("h", StringComparison.OrdinalIgnoreCase))
                {
                    // James - seems that you have a pretty firm grasp of accessing the index of a List, nice job!
                    Console.WriteLine($"{studentList[convertedUserNumber - 1]} is from {studentHome[convertedUserNumber - 1]}.");
                }

                else if (outputKnowMore.StartsWith("f", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{studentList[convertedUserNumber - 1]}'s favorite food is {studentFood[convertedUserNumber - 1]}.");
                }

                else
                {
                    Console.WriteLine("I'm sorry I don't recognize that input.");
                }

                Console.Write("Would you still like to know more? Y or N: ");
                var userRepeat = Console.ReadLine();

                if (userRepeat.StartsWith("y", StringComparison.OrdinalIgnoreCase))
                {
                    repeat = true;
                    Console.WriteLine("Please enter home or food: ");
                    outputKnowMore = Console.ReadLine();
                }

                else
                {
                    repeat = false;
                }
            }

        }


    }
}
