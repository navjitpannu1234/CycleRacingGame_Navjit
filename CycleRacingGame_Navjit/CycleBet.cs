using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleRacingGame_Navjit
{
    public class CycleBet
    {
        //global variables declaration
        public int Amount;
        public int Cycle;
        public CycleClient Bettor;

        public CycleBet(int Amount, int Cycle, CycleClient Bettor)//this is constructor
        {
            this.Amount = Amount;
            this.Cycle = Cycle;
            this.Bettor = Bettor;
        }

        public string GetDescription()//this function is for setting the description of labels when bet is placed and amount is changed
        {
            string description = "";

            if (Amount > 0)
            {
                description = String.Format("{0} bets ${1} on cycle #{2}", Bettor.Name, Amount, Cycle);
            }
            else
            {
                description = String.Format("{0} hasn't placed any bets", Bettor.Name);
            }


            return description;
        }

        public int PayOut(int Winner)//this function is for payout to those who win the race
        {
            if (Cycle == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
