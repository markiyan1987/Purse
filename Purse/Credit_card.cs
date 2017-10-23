using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    class Credit_card : ICard
    {
        public double Cash { set; get; }
        public string Name { get; set; }
        public double income_sum=0;
        public Double outlay_sum=0;
        public Credit_card() { Cash = 0;Name = "CardwithoutName"; }
        public Credit_card(string name, double cash) { this.Cash = cash;this.Name = name; }
        public void Add_money(double sum)
        {
            this.Cash += sum;
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
            if (Cash <= -50000) { Console.WriteLine("Your limit is over"); }
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
