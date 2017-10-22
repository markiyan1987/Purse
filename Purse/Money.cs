using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    class Purse
    {
        List<Card> all_cards = new List<Card>();
        public void Add_card(Card card)
        {
            all_cards.Add(card);
        }
        public double Total_balance()
        {
            double total_balance = 0;
            foreach (Card card in all_cards)
                total_balance += card.Balance();
            return total_balance;
        }
        public double Total_income()
        {
            double total_income = 0;
            foreach (Card card in all_cards)
                total_income += card.Income();
            return total_income;

        }
        public double Total_outlay()
        {
            double total_outlay = 0;
            foreach (Card card in all_cards)
                total_outlay += card.Outlay();
            return total_outlay;

        }
        public void Card_list()
        {
            foreach (Card card in all_cards)
                Console.WriteLine(card.Card_name());
        }
        public void Add_money(double sum, string card_name)
        {
            foreach(Card card in all_cards)
            {
                if (card.Card_name() == card_name)
                    card.Add_money(sum);
            }
        }
        public void Get_cash(double sum, string card_name)
        {
            foreach (Card card in all_cards)
            {
                if (card.Card_name() == card_name)
                    card.Get_cash(sum);
            }
        }
    }
}
