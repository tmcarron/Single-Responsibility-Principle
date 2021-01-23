using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSolidPrinciples
{
    //this class is meant to make sure that the user has inputted a valid name
    class UserValidation
    {
        public static bool IsNameValid(User user)
        {
            //making sure names aren't just whitespace
            if(string.IsNullOrWhiteSpace(user.FirstName) == true)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(user.LastName) == true)
            {
                return false;
            }
            //checking to make sure there aren't any unwanted characters or numbers in the first name
            string unwantedChars = "0123456789!@#$%^&*()_-+=[]{}|\\;:\"\'`~";
            for(int i = 0; i < user.FirstName.Length; i++)
            {
                for(int j = 0; j < unwantedChars.Length; j++)
                {
                    if (user.FirstName[i] == unwantedChars[j])
                    {
                        return false;
                    }
                }
            }
            //Making sure there are no unwatned chars in the last name
            for (int i = 0; i < user.LastName.Length; i++)
            {
                for (int j = 0; j < unwantedChars.Length; j++)
                {
                    if (user.LastName[i] == unwantedChars[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
