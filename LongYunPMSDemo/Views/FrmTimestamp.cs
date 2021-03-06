﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongYunPMSDemo.Views
{
    public partial class FrmTimestamp : Form
    {
        public FrmTimestamp()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            txtBaseURL.Text = SysEnvironment.BaseURL;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            var pms = new LYPMS(txtBaseURL.Text, SysEnvironment.partner_Id, SysEnvironment.hotel_code);
            txtResult.Text = pms.Timestamp();
        }
    }
}
