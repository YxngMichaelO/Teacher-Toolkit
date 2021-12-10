using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_Toolkit
{
    public partial class Timer : Form
    {
        //GLOBAL
        DateTime dt1 = DateTime.Now;
        float countDown = 50;
        float timer = 0;
        public Timer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dt1.ToString(); //put date into textbox

            DateTime dt2 = dt1.AddMinutes(30); //add 30 minutes to dt1
            textBox1.AppendText("\r\n" + dt2.ToString()); //\r\n add new line

            dt2 = dt2.AddMinutes(30);
            textBox1.AppendText("\r\n" + dt2.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          

        }


        private void RollDice_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 6 + 1);
            textBox3.Text = dice1.ToString();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            countDown = 300;
            textBox2.BackColor = Color.Wheat;
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countDown -= timer1.Interval * 0.001f;


            if(countDown<0)
            {
                timer1.Enabled = false;
            }

            textBox2.Text = countDown.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }

}
