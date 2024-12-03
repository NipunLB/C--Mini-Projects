using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBmi.Clear();
            txtHeight.Clear();
            txtIndicator.Clear();
            txtIndicator.BackColor = Color.White;
            txtStatus.Clear();
            txtWeight.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double heightX;
            heightX = Convert.ToDouble(txtHeight.Text);
            double weightY;
            weightY = Convert.ToDouble(txtWeight.Text);

            double bmiAnswer;
            bmiAnswer = weightY / Math.Pow(heightX,2);

            //Display the ansewer
            txtBmi.Text = bmiAnswer.ToString();

            //Display the Status
            if (bmiAnswer < 18.5)
            {
                txtStatus.Text = "Under Weight";
                txtIndicator.BackColor = Color.Red;
            }
            else {
                if (bmiAnswer < 25)
                {
                    txtStatus.Text = "Normal";
                    txtIndicator.BackColor = Color.Blue;
                }
                else {
                    if (bmiAnswer < 30)
                    {
                        txtStatus.Text = "Obesity Class I";
                        txtIndicator.BackColor = Color.Orange;
                    }
                    else {
                        if (bmiAnswer < 40)
                        {
                            txtStatus.Text = "Obesity Class II";
                            txtIndicator.BackColor = Color.Pink;
                        }
                        else {
                            if (40 < bmiAnswer) {
                                txtStatus.Text = "Obesity Class III";
                                txtIndicator.BackColor = Color.Brown;
                            }
                        }
                    }
                }
            }
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
