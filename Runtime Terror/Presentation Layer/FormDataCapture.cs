﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runtime_Terror
{
    public partial class FormDataCapture : Form
    {
        public FormDataCapture()
        {
            InitializeComponent();
        }

        private void FormDataCapture_Load(object sender, EventArgs e)
        {

        }

        private void FormDataCapture_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}