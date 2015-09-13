using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace GreyHoundRacing.Models
{
    public class GreyHound
    {
        public string Name { get; set; }
        public int StartingPosition { get; set; } 
        public int RaceTrackLength;
        public PictureBox dog_Box { get; set; }
        public PictureBox Track { get; set; }
        public Label testing; 
        public bool win;        

        public GreyHound(string name, PictureBox box, PictureBox bigbox, Label speed)
        {
            Name = name;
            dog_Box = box; 
            StartingPosition = bigbox.Left;
            Track = bigbox; 
            RaceTrackLength = bigbox.Width - box.Width;
            testing = speed;
        }

        public void run(int move)
        { 
            if (dog_Box.Location.X <= Track.Width)
            {
                if (move + dog_Box.Location.X  > Track.Width - dog_Box.Width)
                {
                    move = Track.Width - dog_Box.Width - dog_Box.Location.X; 
                }
                dog_Box.Left += move;
            }

            //testing.Text = dog_Box.Location.ToString();

            if (dog_Box.Location.X == Track.Width - dog_Box.Width)
            {
                win = true; 
            }
        }

        public void TakeStartingPosition()
        {
            dog_Box.Left = Track.Left;
        }
    }
}
