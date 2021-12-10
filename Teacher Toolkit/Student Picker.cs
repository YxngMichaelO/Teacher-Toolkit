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
    public partial class Student_Picker : Form
    {
        public Student_Picker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Random rnd = new Random();
            if (listBox1.Items.Count > 0)
            {
                int studentNum = rnd.Next(0, listBox1.Items.Count);
        textBox1.Text = listBox1.Items[studentNum].ToString();

        listBox1.Items.RemoveAt(studentNum);
            }
            else
            {
                MessageBox.Show("Please add students!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.AppendText(textBox2.Text);
        }
    }
}
