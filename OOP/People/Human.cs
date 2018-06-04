using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
    class Human
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
