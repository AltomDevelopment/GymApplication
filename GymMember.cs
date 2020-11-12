using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

        //Come up with a workout layout strategy
        //You should be able to layout the types of workouts, the weight, the reps, calories burned, timers
        //You could add even more functionality then this
    }
}
