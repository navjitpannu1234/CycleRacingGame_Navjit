using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycleRacingGame_Navjit
{
    public partial class CycleRace : Form
    {
        //Creating the objects of classes
        CycleTrack[] cycles = new CycleTrack[4];//instance of tracksetup class
        CycleClient[] guys = new CycleClient[3];//object of client class
        public CycleRace()
        {
            InitializeComponent();
            RaceTrackSetting();//calling the set race track funtion
        }

        private void betBtn_Click(object sender, EventArgs e)
        {
            int GuyNumber = 0;

            if (radioButtonNavjit.Checked)
            {
                GuyNumber = 0;//assign the nuber of navjit radio button
            }
            if (radioButtonKuljit.Checked)
            {
                GuyNumber = 1;//assign the nuber of kuljit radio button
            }
            if (radioButtonRanjit.Checked)
            {
                GuyNumber = 2;//assign the nuber of ranjit radio button
            }

            guys[GuyNumber].PlaceBet((int)numericUpDownBets.Value, (int)numericUpDownCar.Value);//when any radio button is checked then place bet function is called and bet is placed and show amount and car number
            guys[GuyNumber].UpdateLabels();//with this code line the labels are updated
        }

        private void RaceBtn_Click(object sender, EventArgs e)
        {
            CycleRaceStart();//calling the function of cycle race start with this function when we click on the race button the race will start
        }
        private void RaceTrackSetting()//this funtion is for setting the race track
        {
            MinimumBet.Text = string.Format("Minimum Bet $1", (int)numericUpDownBets.Minimum);//Showing the minimum bet rate in label

            int startingPosition = cycleA.Right - cycleRaceTrack.Left; //Setting the variable for starting position from cycle 1
            int raceTrackLength = cycleRaceTrack.Size.Width;//Setting the variable of length of cycletrack

            //Setting values of the array of the class greyhound for racing for the first part of the game as suggested in assignment
            cycles[0] = new CycleTrack()
            {
                MyPictureBox = cycleA,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };

            cycles[1] = new CycleTrack()
            {
                MyPictureBox = cycleB,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            cycles[2] = new CycleTrack()
            {
                MyPictureBox = cycleC,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            cycles[3] = new CycleTrack()
            {
                MyPictureBox = cycleD,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };

            //this part is for assigning the constructor values which is created in guy class
            guys[0] = new CycleClient("Navjit", null, 60, radioButtonNavjit, labelNavjitBet);
            guys[1] = new CycleClient("Kuljit", null, 85, radioButtonKuljit, labelKuljitBet);
            guys[2] = new CycleClient("Ranjit", null, 55, radioButtonRanjit, labelRanjitBet);

            foreach (CycleClient guy in guys)
            {
                guy.UpdateLabels();//using the foreach loop for assigning the values of labels for bet
            }
        }

        private void CycleRaceStart()//this is function for starting the race
        {
            bool NoWinner = true;
            int winningCycle;
            RaceBtn.Enabled = false;//Button will be false whenever race is continue

            while (NoWinner)
            {
                Application.DoEvents();
                for (int i = 0; i < cycles.Length; i++)//loop start and it will continue whenever length of tracksetup class or track is not finished
                {
                    Thread.Sleep(1);//sleep function for the speed of cars
                    if (cycles[i].Run())//here run function is called from greyhound class for running the cycle and condition is checked for three random cycles
                    {
                        winningCycle = i + 1;
                        NoWinner = false;
                        MessageBox.Show("We have a winner - Cycle #" + winningCycle);
                        foreach (CycleClient guy in guys)
                        {
                            if (guy.MyBet != null)//condition is checked for betting
                            {
                                guy.Collect(winningCycle);
                                guy.MyBet = null;
                                guy.UpdateLabels();
                            }
                        }

                        foreach (CycleTrack cycle in cycles)
                        {
                            cycle.TakeStartingPosition();
                        }

                        break;
                    }
                }

            }

            RaceBtn.Enabled = true;//here race button is enabled when race is finished

        }
    }
}
