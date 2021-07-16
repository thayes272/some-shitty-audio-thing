using System;
using System.IO;
using System.Media;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;


namespace Mp3Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer sound = new SoundPlayer();
        OpenFileDialog openfile = new OpenFileDialog();
        //Mp3FileReader sound;

        private void playBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sound.SoundLocation);
            sound.Play();
            if(sound == null)
            {
                MessageBox.Show("Please choose your song before playing!");
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            var path = string.Empty;

            using (openfile)
            {
                openfile.Filter = "wav (*.wav)| *.wav";

                if(openfile.ShowDialog() == DialogResult.OK)
                {
                    //get path
                    path = openfile.FileName;
                }
            }
            sound.SoundLocation = path;
            
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            sound.Stop();
        }
    }
}
