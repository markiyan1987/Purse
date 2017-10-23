using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    interface ICard
    {
        double Balance();
        double Income();
        double Outlay();
        string Card_name();
        void Add_money(double sum);
        void Get_cash(double sum);

    }
}
