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
        public string userInput { get; set; }
        public void GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            this.userInput = Console.ReadLine();
        }
    }
}
