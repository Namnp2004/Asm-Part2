﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SaleManagementWinform
{
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee(string code, string fullname, string position, string username, string password)
        {

            InitializeComponent();
            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            // Disable the maximize/restore button
            this.MaximizeBox = false;
            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}