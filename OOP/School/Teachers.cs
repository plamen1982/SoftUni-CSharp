using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Teachers : People
    {
        public string Subject { get; set; }
        public Teachers(string name, string subject) : base(name)
        {
            this.Subject = subject;
        }
    }
}
