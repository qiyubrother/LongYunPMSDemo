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

namespace LongYunPMSDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnTimestamp_Click(object sender, EventArgs e)
        {
            (new FrmTimestamp()).ShowDialog();
        }
    }
}
