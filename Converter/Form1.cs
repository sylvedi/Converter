using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 
//Sylvanus Edi
//This is my program
// 01/31/2019
//
namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Convert_Click(object sender, EventArgs e)
        {
            try
            {

                //Get the exchange rate from the exchange text box

                string strNumber = textBox_number.Text;
                //Convert currency
                double number = double.Parse(strNumber);
                //convert USD into Naira
                double result = number * 361.75;
                //display USD in Nigeria Naria
                textBox_result.Text = result.ToString();



            }
            //display error if input is empty
            catch
            { textBox_result.Text = "Error";

            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   //close program
            this.Close();

        }
    }
}
