using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region variables
            
            string userFirstName;
            string userLastName;
            
            int userAge;

            #endregion

            #region console_output

            // User greeting.
            Console.WriteLine("User: Hello World!"); // Prints out "Hello World!" to console.
            Console.ReadLine(); // Waits for user input before proceeding, acting effectively as a pause.

            // World response.
            Console.WriteLine("World: Hello User! What is your first name?"); // World asks for User's first name.

            // User response, first name.
            userFirstName = Console.ReadLine(); // Takes input from User and stores it in a var titled userFirstName.

            // World response to first name.
            Console.WriteLine("World: {0} is a lovely name! Now, what is your last name?", userFirstName); // World responds to User's answer, proceeds to ask for User's last name.

            // User response, last name.
            userLastName = Console.ReadLine(); // Takes input from User and stores it in a var titled userLastName.

            // World response to last name.
            Console.WriteLine("World: {0} is a fantastic last name! Last question, what is your age?", userLastName); // World responds to User's answer, proceeds to ask for User's age.

            // User response, age.
            userAge = Convert.ToInt32(Console.ReadLine()); // Takes input from User and stores it in a var titled userAge.

            // World response to age.
            Console.WriteLine("World: Ah, I remember when I was {0}, that's a great age.", userAge); // World responds to User's answer.

            Console.ReadLine(); // Waits for user input before proceeding, acting effectively as a pause.
            
            #endregion
        }
    }
}
