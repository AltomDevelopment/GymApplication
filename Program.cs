using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            UI userStory = new UI();
            userStory.GetUserInput("Enter your FirstName: ");
            /* Basic Functionality
             * What would you like this application to do?
             * Allow the user to enter the credentials to become a new gym member
             * Give the user a passcode that they will enter to access their workouts
             * Store a list of members and retrieve their workout list only after they have entered a passscode
             * Break out categories for different workout types */
        }
    }
}
