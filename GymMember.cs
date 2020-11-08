using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApplication
{
    class GymMember
    {
        //Creates a new instance of a gym member
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int passCode { get; set; }
        public GymMember(string firstName, string lastName, int passCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.passCode = passCode;
        }

        //Define in more detail what you would like accomplished by this application
    }
}
