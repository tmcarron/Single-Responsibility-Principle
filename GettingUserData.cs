using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSolidPrinciples
{
    class GettingUserData
    {
        //this class's job is to get data to be assigned to thew user
        public static User GetUserName()
        {
            User person = new User();
            Console.WriteLine("Please enter your first name.");
            Console.Write("First Name: ");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            Console.Write("Last Name: ");
            person.LastName = Console.ReadLine();
            return person;
        }
    }
}
