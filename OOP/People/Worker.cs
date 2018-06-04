using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
    class Worker : Human
    {
        public int MoneyPerHour { get; set; }
        public int Hours { get; set; }
        public int calculateMoney()
        {
            return this.Hours * this.MoneyPerHour;
        }
        public Worker(string firstName, string lastName, int moneyPerHour, int hours) : base(firstName, lastName)
        {
            this.Hours = hours;
            this.MoneyPerHour = moneyPerHour;
        }
    }
}
