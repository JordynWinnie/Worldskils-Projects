﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPQR_Session2_8_31_2020
{
    public partial class SponsorMainMenu : Form
    {
        private string _userId = string.Empty;

        public SponsorMainMenu(string userID)
        {
            _userId = userID;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            (new BookSponsorshipPackages(_userId)).ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            (new UpdateBooking(_userId)).ShowDialog();
            Show();
        }
    }
}