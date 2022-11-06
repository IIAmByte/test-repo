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
            Console.WriteLine("World: Hello User! What is your first name?");

            // User response, first name.
            userFirstName = Console.ReadLine();

            // World response to first name.
            Console.WriteLine("World: {0} is a lovely name! Now, what is your last name?", userFirstName);

            // User response, last name.
            userLastName = Console.ReadLine();

            // World response to last name.
            Console.WriteLine("World: {0} is a fantastic last name! Last question, what is your age?", userLastName);

            // User response, age.
            userAge = Convert.ToInt32(Console.ReadLine());

            // World response to age.
            Console.WriteLine("World: Ah, I remember when I was {0}, that's a great age.", userAge);

            Console.ReadLine(); // Waits for user input before proceeding, acting effectively as a pause.
            
            #endregion
        }
    }
}
