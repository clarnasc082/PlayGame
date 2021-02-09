using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Play_Game
{
    public partial class goLabel : Form
    {
        public goLabel()
        {
            InitializeComponent();//
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            SoundPlayer doorSound = new SoundPlayer(Properties.Resources.Store_Door_Chime_Mike_Koenig_570742973);
            doorSound.Play();

            startButton.Visible = false;
           
            Refresh();
            Thread.Sleep(1000);

            numberLabel.Text = "2";
            Refresh();
            Thread.Sleep(1000);

            numberLabel.Text = "1";
            Refresh();
            Thread.Sleep(1000);

            numberLabel.Visible = false; 
            
            gameStartLabel.Visible = false;
            this.BackColor = Color.Green;
            Refresh();
            Thread.Sleep(1000);

            label1.Visible = true;

        }
    }
}
