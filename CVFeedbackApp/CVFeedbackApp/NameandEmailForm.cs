﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVFeedbackApp
{
    public partial class NameandEmailForm : Form
    {
        public NameandEmailForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReplySelctionForm Select = new ReplySelctionForm();
            Select.ShowDialog();
            this.Close();
        }
    }
}