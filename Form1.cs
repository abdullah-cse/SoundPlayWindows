using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SoundPlayWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            SoundPlayer saplay = new SoundPlayer(@"C:\Users\abdul\source\repos\SoundPlayWindows\bin\Debug\a.wav");
            if (buttonPlay.Text=="Play")
            {
                buttonPlay.Text = "Stop";
                saplay.Play();
            }
            else
            {
                buttonPlay.Text = "Play";
                saplay.Stop();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
