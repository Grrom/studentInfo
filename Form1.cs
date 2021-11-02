using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studendInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 31; i++)
            {
                this.comboBox1.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                this.comboBox2.Items.Add(i);
            }
            for (int i = 1900; i <= 2021; i++)
            {
                this.comboBox3.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox2.Text + " " + textBox3.Text + " " + textBox1.Text;
            String gender = checkBox1.Checked ? "male" : checkBox2.Checked ? "female" : "didn't mention, probably gay or something";
            String date = comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text;
            new Form2(name, gender, date).Show();
        }
    }
}
