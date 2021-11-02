using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace studendInfo
{
    public partial class Form2 : Form
    {
        public Form2(String name, String gender, String date)
        {
            InitializeComponent();
            label4.Text = name;
            label5.Text = gender;
            label6.Text = date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
