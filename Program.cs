using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();
            User user = GettingUserData.GetUserName();
            bool isNameValid = UserValidation.IsNameValid(user);
            if(isNameValid == false)
            {
                Console.WriteLine("Sorry, that name is not valid.");
                return;
            }

            StandardMessages.ClosingMessage(user);
        }
    }
}
