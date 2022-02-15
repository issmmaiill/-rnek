using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i = 1;
            int s1 ;

            while (i < Convert.ToInt32(textBox2.Text))
                
            {
                listBox1.Items.Add(textBox1.Text);
                s1 = Convert.ToInt32(textBox2.Text);
                i++;

            }
        }
    }
}