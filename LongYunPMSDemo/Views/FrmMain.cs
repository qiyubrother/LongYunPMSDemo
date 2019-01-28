using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LongYunPMSDemo.Views;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace LongYunPMSDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        JObject jo = null;
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            var s = File.ReadAllText("config.json");

            jo = JsonConvert.DeserializeObject<JObject>(s);
            SysEnvironment.BaseURL = jo["BaseURL"].ToString();
            SysEnvironment.partner_Id = jo["partner_Id"].ToString();
            SysEnvironment.hotel_code = jo["hotel_code"].ToString();
        }

        private void btnTimestamp_Click(object sender, EventArgs e)
        {
            (new FrmTimestamp()).ShowDialog();
        }

        private void btnResvList_Click(object sender, EventArgs e)
        {
            (new FrmResvList()).ShowDialog();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            (new FrmSetup()).ShowDialog();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            jo["BaseURL"] = SysEnvironment.BaseURL;
            jo["partner_Id"] = SysEnvironment.partner_Id;
            jo["hotel_code"] = SysEnvironment.hotel_code;

            File.WriteAllText("config.json", JsonConvert.SerializeObject(jo));
        }

        private void btnResvcheckin_Click(object sender, EventArgs e)
        {
            (new FrmResvCheckin()).ShowDialog();
        }
    }
}
