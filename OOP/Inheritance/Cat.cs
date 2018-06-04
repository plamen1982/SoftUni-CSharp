using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Cat : Mammal
    {
        public string Myau { set; get; }

        public Cat(int age, string myau) : base(age)
        {
            this.Myau = myau;
        }

    }
}
