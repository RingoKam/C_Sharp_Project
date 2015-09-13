using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreyHoundRacing.Models;

namespace GreyHoundRacing
{
    public partial class x : System.Windows.Forms.Form
    {
        private GreyHound[] dog_list;
        private List<Gambler> gambler_list = new List<Gambler>(); 
        private Random rnd = new Random(); //make one instance of random to ensure random is not shared among all 4 dog

        public x()//workflow goes here...

        {
            InitializeComponent();
            Gambler joe = new Gambler("Joe", RadioJoe, Joe_Bet_Label);
            Gambler ringo = new Gambler("Ringo", Radio_Ringo, Ringo_Bet_Label);
            Gambler alex = new Gambler("Alex", Radio_Alex, Alex_Bet_Label);
            GreyHound Adog = new GreyHound("A DOG", Dog1, pictureBox1, Testing);
            GreyHound Bdog = new GreyHound("B DOG", Dog2, pictureBox1, Testing);
            GreyHound Cdog = new GreyHound("C DOG", Dog3, pictureBox1, Testing);
            GreyHound Ddog = new GreyHound("D DOG", Dog4, pictureBox1, Testing);

            gambler_list = new List<Gambler>
            {
                joe,
                alex,
                ringo
            };

            dog_list = new GreyHound[]
            {
                Adog,
                Bdog,
                Cdog,
                Ddog
            };
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Bet_Amount.Text = "$"+trackBar1.Value.ToString();
        }
       
        private void RaceStart_Click(object sender, EventArgs e)
        {
            if (gambler_list.All(x => x.MyBet != null))
            {
                RaceStart.Enabled = false; 
                race_timer.Enabled = true;
                race_timer.Start();

                foreach (var dog in dog_list)
                {
                    int move = rnd.Next(1, 20);
                    dog.run(move);

                    if (dog.win == true)
                    {
                        foreach (var gambler in gambler_list)
                        {
                            gambler.Collect();
                            gambler.UpdateLabels();
                        }
                        race_timer.Stop();
                        MessageBox.Show($"{dog.Name} WINS");
                        cleanup();
                        RaceStart.Enabled = true;
                        break;
                    }
                }

            }
            else
            {
                var nameNoBet = gambler_list.Where(n => n.MyBet == null);

                string List_of_noBet = "";  

                foreach (var name in nameNoBet)
                {
                    List_of_noBet += name.Name + " "; 
                }
                MessageBox.Show($"please place your bet : {List_of_noBet}"); 
            }
        }

        private void Button_Bets_Click(object sender, EventArgs e)
        {
            foreach (var gambler in gambler_list)
            {
                if (gambler.MyRadioButton.Checked)
                {
                    if (gambler.cash < trackBar1.Value || trackBar1.Value < 5)
                    {
                        MessageBox.Show("Invalid Bet."); 
                    }
                    else
                    {
                        gambler.PlaceBet(trackBar1, numericUpDown1, dog_list);
                    }
                }
            }
        }

        private void cleanup()
        {
            //clean up
            foreach (var dog in dog_list)
            {
                dog.win = false; 
                dog.TakeStartingPosition();
            }
            foreach (var player in gambler_list)
            {
                player.ClearBet();
                player.UpdateLabels();
            }
        }
    }
}
