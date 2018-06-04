using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Students : People
    {
        public int Id {get; set;}
        public Students(string name, int id) : base(name)
        {
            this.Id = id;
        }
    }
}
