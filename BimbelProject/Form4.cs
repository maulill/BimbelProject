﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BimbelProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form05 form = new Form05();
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form6 form = new Form6();
            form.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.ShowDialog();
        }
    }
}
