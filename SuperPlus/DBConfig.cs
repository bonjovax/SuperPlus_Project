﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace SuperPlus
{
    public partial class DBConfig : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DBConfig()
        {
            InitializeComponent();
        }

        private void DBConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.ExitThread(); //
        }

        private void DBConfig_Load(object sender, EventArgs e)
        {

        }
    }
}