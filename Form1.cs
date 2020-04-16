using System;
using System.Media;
using System.Windows.Forms;

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
            musicPlay(@"C:\Users\abdul\source\repos\SoundPlayWindows\bin\Debug\a.wav");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Method to Play music, just pass a string from where to play

        private void musicPlay(string a)
        {
            SoundPlayer saplay = new SoundPlayer(a);
            if (buttonPlay.Text == "Play")
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
    }
}
