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
    public partial class FrmResvCheckin : Form
    {
        public FrmResvCheckin()
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
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("无效的姓名");
                return;
            }
            if (txtCertNum.Text.Trim() == string.Empty)
            {
                MessageBox.Show("无效的证件号");
                return;
            }
            if (txtGender.Text != "1" && txtGender.Text != "2")
            {
                MessageBox.Show("无效的性别");
                return;
            }
            if (!int.TryParse(txtGuestId.Text, out int _guestId))
            {
                MessageBox.Show("无效的客户ID");
                return;
            }

            var resvCheckin = new ResvCheckin();
            var checkinItem = new ResvCheckinItem();
            checkinItem.GuestId = Convert.ToInt32(txtGuestId.Text); // 预定查询的m_Item1数据项
            checkinItem.GuestInfo = new GuestInfo
            {
                Name = txtName.Text,
                CertNum = txtCertNum.Text,
                CertType = txtCertType.Text,
                Gender = Convert.ToInt32(txtGender.Text),
                Nationality = string.Empty,
                Birthday = string.Empty,
                Address = string.Empty,
                Country = string.Empty,
                ValidTime = string.Empty,
                Picture = string.Empty
            };
            resvCheckin.guestinfo[0] = checkinItem;
            var pms = new LYPMS(txtBaseURL.Text, SysEnvironment.partner_Id, SysEnvironment.hotel_code);
            txtResult.Text = pms.Resvcheckin(txtPMSAccount.Text, resvCheckin);
        }
    }
}
