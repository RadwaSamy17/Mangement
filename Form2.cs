using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
       public double[,] matric = new double[2, 3];
         
      
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            matric[1, 2] = double.Parse(textBox8.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            matric[0, 0] = double.Parse(textBox1.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        { matric[0, 1] = double.Parse(textBox1.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            matric[1, 0] = double.Parse(textBox1.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            matric[1, 1] = double.Parse(textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            matric[1,2] = double.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
           
            

               
                for (int s = 0; s < 2; s++)
                {
                    double leading = matric[s, s];


                    for (int j = 0; j < 3; j++)
                    { matric[s, j] = (1 / leading * matric[s, j]); textBox5.Text = Convert.ToString(matric[0, 0] + matric[0, 1] + matric[0,2]); }

                    for (int k = 0; k < 2; k++)
                    {
                        leading = matric[k, s];
                        if (s != k)
                        {
                            for (int j = 0; j < 3; j++)
                            { matric[k, j] = matric[k, j] - (leading * matric[s, j]); }

                          

                        }
                    }
                }
                textBox6.Text = Convert.ToString(matric[0, 2]);
                textBoxm5.Text = Convert.ToString(matric[1, 2]);
            }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxm5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
     
    
        }

      
    

}
