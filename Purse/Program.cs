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
            purse.Add_card(new Gold_card());
            purse.Add_card(new Credit_card());
            purse.Add_card(new Business_card());
        }
    }
}
