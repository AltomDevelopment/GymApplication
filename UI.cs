using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApplication
{
    class UI
    {
        //Can take and store user input
        public UI()
        {

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Random Passcode = new Random(100);
        public void GetUserInput()
        {
            Console.WriteLine("Welcome to the gym");
            Console.WriteLine("Please enter your First Name: ");
            this.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your Last Name: ");
            this.LastName = Console.ReadLine();
        }
    }
}
