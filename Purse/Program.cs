using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            Purse purse = new Purse();
            Credit_card c1 = new Credit_card("D.Pukhir", 4098);
            c1.Balance();
            c1.Card_name();
            c1.Income();
            c1.Outlay();
            c1.Add_money(300);
            c1.Get_cash(500);
            purse.Add_card(c1);

            purse.Add_money(800, "D.Pukhir");
            purse.Card_list();
            Console.WriteLine(purse.Total_balance());
            Console.WriteLine(purse.Total_income());
            purse.Get_cash(20000, "D.Pukhir");

            purse.Add_card(new Gold_card());
            
            purse.Add_card(new Business_card());
              
            
        }
    }
}
