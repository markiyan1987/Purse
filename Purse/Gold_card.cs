using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    class Gold_card : ICard
    {
        public string Name { get; set; }
        public double Cash { set; get; }
        double income_sum=0;
        double outlay_sum=0;
        public Gold_card() {
            Cash=0;
            Name="Gold_card";
        }
        public Gold_card(string name, double cash)
        {   this.Cash = cash;
            this.Name = name;
            income_sum = +Cash;
        }
        public void Add_money(double sum)
        {
            Cash += sum;
            income_sum += sum;
        }

        public double Balance()
        {
            return Cash;
        }

        public string Card_name()
        {
            return Name;
        }

        public void Get_cash(double sum)
        {
            if (Cash <= -150000) { Console.WriteLine("Your limit is over");
                return; }
            if (Cash - sum <= -150000)  Console.WriteLine("Not enough money. Out of limit");
            else
            {
                Cash -= sum;
                outlay_sum += sum;
            }
        }

        public double Income()
        {

            return income_sum;
        }

        public double Outlay()
        {
            return outlay_sum;
        }
       
    }
}
