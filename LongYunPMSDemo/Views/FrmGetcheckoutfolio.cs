using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongYunPMSDemo
{
    public partial class FrmGetcheckoutfolio : Form
    {
        public FrmGetcheckoutfolio()
        {
            InitializeComponent();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            txtBaseURL.Text = SysEnvironment.BaseURL;
            txtPartnerId.Text = SysEnvironment.partner_Id;
            txtHotelId.Text = SysEnvironment.hotel_code;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            var pms = new LYPMS(txtBaseURL.Text, SysEnvironment.partner_Id, SysEnvironment.hotel_code);
            txtResult.Text = pms.GetcheckoutFolio(txtPMSAccountNum.Text);
        }
    }
}
