using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycleRacingGame_Navjit
{
    public class CycleClient
    {
        //declaration of global variables 
        public string Name;
        public CycleBet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public CycleClient(string Name, CycleBet MyBet, int Cash, RadioButton MyRadioButton, Label MyLabel) //this is constructor
        {
            this.Name = Name;
            this.MyBet = MyBet;
            this.Cash = Cash;
            this.MyRadioButton = MyRadioButton;
            this.MyLabel = MyLabel;
        }

        public void UpdateLabels()//Update labels method
        {
            if (MyBet == null)
            {
                MyLabel.Text = String.Format("{0} hasn't placed any bets", Name);
            }
            else
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            MyRadioButton.Text = Name + " has " + Cash + " bucks";

            if (Cash == 0)//Code When bettor has no money to bet then it gets destroy
            {
                MyLabel.Text = String.Format("BUSTED");
                MyLabel.ForeColor = System.Drawing.Color.Red;
                MyRadioButton.Enabled = false;
            }

        }

        public void ClearBet() //clear bet method for clearing the bet
        {
            MyBet.Amount = 0;
        }

        public bool PlaceBet(int Amount, int Cycle)//place bet method for betting
        {
            if (Amount <= Cash)
            {
                //MyLabel.Text = "Busted";
                MyBet = new CycleBet(Amount, Cycle, this);
                return true;
            }

            return false;
        }

        public void Collect(int Winner)//collect method for collecting the cash
        {
            Cash += MyBet.PayOut(Winner);
        }
    }
}
