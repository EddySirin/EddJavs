﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HojaDeTrabajo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Green;
            label2.Visible=true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Yellow;
        }

       private void panel1_Paint(object sender, PaintEventArgs e)
         {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
