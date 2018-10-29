using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._8._9
{
    class Students
    {
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
            

        public string GetStudent(int convertedUserNumber)
        {

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
