using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace GSAdminC
{
    public partial class egg : Form
    {
        public egg()
        {
            InitializeComponent();
        }

        private void egg_Load(object sender, EventArgs e)
        {
            playSound(true);
        }

        public void playSound(bool value)
        {
            System.IO.Stream s = GSAdminC.Properties.Resources.simmons1;
            SoundPlayer player = new SoundPlayer(s);

            if (value == true)
            {
                player.PlayLooping();
            }
            else
            {
                player.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "22")
            {
                MessageBox.Show("Think outsiiiiiide the box :)");
            }
            else
            {
                string response;
                response = Microsoft.VisualBasic.Interaction.InputBox("Okay. You're a worthy one! :) Nowww. One last question.. Please Answer the Ultimate Question of Life, the Universe, and Everything:", "Last question..", "", this.Location.X, this.Location.Y);

                if(response == "42"){
                    MessageBox.Show("TADAAAAA! Thx for playing :)");
                    playSound(false);
                    this.Dispose();
                }else{
                    MessageBox.Show("Nooo, you spoon! Try again!");
                    textBox1.Text = "";
                }
            }
        }
    }
}
