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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dateTime();
            textBoxTotal.ReadOnly = true;
        }
        
        private void dateTime()
        {
            string hora = DateTime.Now.ToString("HH:mm:ss");
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            labelday.Text = fecha;
            labelhour.Text = hora;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTime();
        }

        private void calculate(object sender, EventArgs e)
        {
            double price = 0;
            int row = 0;
            double[,] priceList = {
                {5, 10, 5, 20, 0}, //niño
                {7, 25, 8, 50, 60}, //mujer
                {5, 15, 7, 35, 40} //hombre
                };
            if (radioButtonChildren.Checked) row = 0;
            else if (radioButtonWomen.Checked) row = 1;
            else if (radioButtonMen.Checked) row = 2;

            if (checkBoxWash.Checked) price += priceList[row, 0];
            if (checkBoxCutHairdo.Checked) price += priceList[row, 1];
            if (checkBoxHairdo.Checked) price += priceList[row, 2];
            if (checkBoxDye.Checked) price += priceList[row, 3];
            if (checkBoxPermanent.Checked) price += priceList[row, 4];
            textBoxTotal.Text = price.ToString()+" €";

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
