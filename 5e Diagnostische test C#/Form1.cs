using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5e_Diagnostische_test_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gewicht;
            double lengte;
            double bmi;
            string catogorie = "";
            gewicht = int.Parse(textBox3.Text);
            lengte = double.Parse(textBox2.Text);
            bmi = gewicht / (lengte * lengte);

            if (bmi < 18.5) 
            {
                catogorie = "Ondergewicht";
            }
            if (bmi > 18.5)
            {
                catogorie = "Gezond Gewicht";    
            }
            if (bmi > 25.0)
            {
                catogorie = "Overgewicht";
            }
            if (bmi > 30.0)
            {
                catogorie = "Obesitas";
            }
            if (bmi > 40.0)
            {
                catogorie = "Morbide Obesitas";
            }
            richTextBox1.Text += comboBox1.Text + " heeft een bmi van " + (Math.Round(bmi * 10) / 10).ToString() + " die in de volgende categorie hoort: " + catogorie + "\n\n";
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Persoon1":
                    textBox2.Text = "1,83";
                    textBox3.Text = "53";
                    radioButton1.Checked = true;
                    textBox4.Text = "16";
                    break;

                case "Persoon2":
                    textBox2.Text = "1,80";
                    textBox3.Text = "61";
                    radioButton1.Checked = true;
                    textBox4.Text = "19";
                    break;

                case "Persoon3":
                    textBox2.Text = "1,83";
                    textBox3.Text = "90";
                    radioButton1.Checked = true;
                    textBox4.Text = "16";
                    break;

                case "Persoon4":
                    textBox2.Text = "1,83";
                    textBox3.Text = "105";
                    radioButton1.Checked = true;
                    textBox4.Text = "16";
                    break;

                case "Persoon5":
                    textBox2.Text = "1,73";
                    textBox3.Text = "127";
                    radioButton1.Checked = true;
                    textBox4.Text = "17";
                    break;
            }
    }
    }
}
