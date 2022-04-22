using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        //declaraciones globales
        private int counter = 0;

        //constructor
        public Form1()
        {
            InitializeComponent();
            Config();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            labelCounter.Text = counter.ToString();
            if (counter <= 100)  progressBar1.Value = counter;
            progressBar1.Value = counter - 1;
            if (counter>=101)
            {
                Form f2 = new Form2();
                f2.Show();
                this.Hide();
                timer1.Enabled = false;
            }
            
        }
        private void Config()
        {
            //MessageBox.Show(Application.StartupPath);
            string resourcesPath = Application.StartupPath + "\\resources\\v1.mp4";
            axWindowsMediaPlayer1.URL = resourcesPath;
            axWindowsMediaPlayer1.uiMode = "none";
        }
    }
}
