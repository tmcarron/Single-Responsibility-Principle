using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSolidPrinciples
{
    //S in SOLID, single responsibility principle. This class's responsibility it to send standardized messages to the user
    class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Hello, welcome to the program! This program was created by me, Tyler Carron,");
            Console.WriteLine("to demonstrate the S in SOLID principles. Single responsibility!");
        }
        public static void ClosingMessage(User person)
        {
            Console.WriteLine("Goodbye " + person.FirstName + " " + person.LastName + "!");
        }
    }
}
