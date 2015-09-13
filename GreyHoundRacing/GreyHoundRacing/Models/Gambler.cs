using System.Linq;
using System.Windows.Forms;

namespace GreyHoundRacing.Models
{
    public class Gambler
    {
        public string Name { get; set; }
        public Bet MyBet { get; private set;  }
        public int cash { get; private set; }
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public Gambler(string name, RadioButton button, Label label)
        {
            Name = name;
            cash = 50; 
            MyRadioButton = button;
            MyLabel = label;
            UpdateLabels(); 
        }

        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " $" + cash;

            if (MyBet != null && MyBet.amount != 0)
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            else
            {
                MyLabel.Text = "No Bet Placed";
            }
        }

        public void PlaceBet(TrackBar trackBar, NumericUpDown numericUp, GreyHound[] dog_list)
        {
            MyBet = new Bet();
            MyBet.player = this; 
            MyBet.dog = dog_list[((int) numericUp.Value)-1]; 
            MyBet.amount = trackBar.Value;
            cash -= MyBet.amount; 
            UpdateLabels();
        }

        public void ClearBet()
        {
            MyBet = new Bet();
        }

        public void Collect()
        {
            cash += MyBet.Payout();
        }
    }
}   