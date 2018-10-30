using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._8._9
{
    class Program
    {
        static void Main(string[] args)
        {
            var doAgain = true;
            // James - I would consider breaking the logic in this Main method into a few methods, this will help keep your code
            // a little more organized.
            while (doAgain)
            {
                Console.WriteLine("Which student would you like to know more about? Please enter a number between 1-20: ");
                var userEntry = int.TryParse(Console.ReadLine(), out int userNumber);

                if (userEntry != true)
                {
                    Console.WriteLine("I'm sorry I don't recognize that input.");
                }

                else
                {

                    var studentOutput = new Students();
                    string convertedStudentOutput = Convert.ToString(studentOutput.GetStudent(userNumber));

                    var studentOutput2 = new Students();
                    studentOutput2.GetInfo(userNumber, convertedStudentOutput);

                    Console.Write("Would you like to search a different student? Y or N: ");
                    var userRepeat = Console.ReadLine();
                    if (userRepeat.StartsWith("Y", StringComparison.OrdinalIgnoreCase))
                    {
                        doAgain = true;
                    }

                    else
                    {
                        doAgain = false;
                    }
                }
            }
        }

    }
}
