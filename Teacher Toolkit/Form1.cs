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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer form = new Timer();           
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student_Picker form = new Student_Picker();
            form.Show();
        }
    }
}
