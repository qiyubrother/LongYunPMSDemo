using System;
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
    public partial class FrmSetup : Form
    {
        public FrmSetup()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            txtBaseURL.Text = SysEnvironment.BaseURL;
            txtPartnerId.Text = SysEnvironment.partner_Id;
            txtHotelCode.Text = SysEnvironment.hotel_code;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SysEnvironment.BaseURL = txtBaseURL.Text;
            SysEnvironment.partner_Id = txtPartnerId.Text;
            SysEnvironment.hotel_code = txtHotelCode.Text;
            MessageBox.Show("OK");
            Close();
        }
    }
}
