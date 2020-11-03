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
            var userStory = new UI();
            userStory.GetUserInput("Enter your FirstName: ");
        }
    }
}
