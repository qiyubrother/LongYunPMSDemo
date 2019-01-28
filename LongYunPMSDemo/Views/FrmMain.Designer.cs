using System.Windows.Forms;

namespace LongYunPMSDemo
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTimestamp = new System.Windows.Forms.Button();
            this.btnResvList = new System.Windows.Forms.Button();
            this.buttonX2 = new System.Windows.Forms.Button();
            this.btnResvcheckin = new System.Windows.Forms.Button();
            this.btnUPloadRMKey = new System.Windows.Forms.Button();
            this.btnGetaccnumtbyrm = new System.Windows.Forms.Button();
            this.btnGetcheckoutfolio = new System.Windows.Forms.Button();
            this.buttonX7 = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTimestamp
            // 
            this.btnTimestamp.Location = new System.Drawing.Point(12, 12);
            this.btnTimestamp.Name = "btnTimestamp";
            this.btnTimestamp.Size = new System.Drawing.Size(178, 44);
            this.btnTimestamp.TabIndex = 1;
            this.btnTimestamp.Text = "获取服务器时间戳";
            this.btnTimestamp.UseVisualStyleBackColor = false;
            this.btnTimestamp.Click += new System.EventHandler(this.btnTimestamp_Click);
            // 
            // btnResvList
            // 
            this.btnResvList.Location = new System.Drawing.Point(12, 62);
            this.btnResvList.Name = "btnResvList";
            this.btnResvList.Size = new System.Drawing.Size(178, 44);
            this.btnResvList.TabIndex = 2;
            this.btnResvList.Text = "预订查询";
            this.btnResvList.UseVisualStyleBackColor = false;
            this.btnResvList.Click += new System.EventHandler(this.btnResvList_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.Location = new System.Drawing.Point(12, 112);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(178, 44);
            this.buttonX2.TabIndex = 2;
            this.buttonX2.Text = "押金/支付";
            this.buttonX2.UseVisualStyleBackColor = false;
            // 
            // btnResvcheckin
            // 
            this.btnResvcheckin.Location = new System.Drawing.Point(12, 162);
            this.btnResvcheckin.Name = "btnResvcheckin";
            this.btnResvcheckin.Size = new System.Drawing.Size(178, 44);
            this.btnResvcheckin.TabIndex = 2;
            this.btnResvcheckin.Text = "预订开房";
            this.btnResvcheckin.UseVisualStyleBackColor = false;
            this.btnResvcheckin.Click += new System.EventHandler(this.btnResvcheckin_Click);
            // 
            // btnUPloadRMKey
            // 
            this.btnUPloadRMKey.Location = new System.Drawing.Point(12, 212);
            this.btnUPloadRMKey.Name = "btnUPloadRMKey";
            this.btnUPloadRMKey.Size = new System.Drawing.Size(178, 44);
            this.btnUPloadRMKey.TabIndex = 2;
            this.btnUPloadRMKey.Text = "上传房卡信息";
            this.btnUPloadRMKey.UseVisualStyleBackColor = false;
            this.btnUPloadRMKey.Click += new System.EventHandler(this.btnUPloadRMKey_Click);
            // 
            // btnGetaccnumtbyrm
            // 
            this.btnGetaccnumtbyrm.Location = new System.Drawing.Point(12, 262);
            this.btnGetaccnumtbyrm.Name = "btnGetaccnumtbyrm";
            this.btnGetaccnumtbyrm.Size = new System.Drawing.Size(178, 44);
            this.btnGetaccnumtbyrm.TabIndex = 2;
            this.btnGetaccnumtbyrm.Text = "查询在店客人账号";
            this.btnGetaccnumtbyrm.UseVisualStyleBackColor = false;
            this.btnGetaccnumtbyrm.Click += new System.EventHandler(this.btnGetaccnumtbyrm_Click);
            // 
            // btnGetcheckoutfolio
            // 
            this.btnGetcheckoutfolio.Location = new System.Drawing.Point(12, 312);
            this.btnGetcheckoutfolio.Name = "btnGetcheckoutfolio";
            this.btnGetcheckoutfolio.Size = new System.Drawing.Size(178, 44);
            this.btnGetcheckoutfolio.TabIndex = 2;
            this.btnGetcheckoutfolio.Text = "获取结账账单";
            this.btnGetcheckoutfolio.UseVisualStyleBackColor = false;
            this.btnGetcheckoutfolio.Click += new System.EventHandler(this.btnGetcheckoutfolio_Click);
            // 
            // buttonX7
            // 
            this.buttonX7.Location = new System.Drawing.Point(12, 362);
            this.buttonX7.Name = "buttonX7";
            this.buttonX7.Size = new System.Drawing.Size(178, 44);
            this.buttonX7.TabIndex = 2;
            this.buttonX7.Text = "结账";
            this.buttonX7.UseVisualStyleBackColor = false;
            this.buttonX7.Click += new System.EventHandler(this.buttonX7_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(12, 412);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(178, 44);
            this.btnSetup.TabIndex = 3;
            this.btnSetup.Text = "设置";
            this.btnSetup.UseVisualStyleBackColor = false;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.buttonX7);
            this.Controls.Add(this.btnGetcheckoutfolio);
            this.Controls.Add(this.btnGetaccnumtbyrm);
            this.Controls.Add(this.btnUPloadRMKey);
            this.Controls.Add(this.btnResvcheckin);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.btnResvList);
            this.Controls.Add(this.btnTimestamp);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "龙云PMS和自助机Check-In设备接口 测试工具";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTimestamp;
        private Button btnResvList;
        private Button buttonX2;
        private Button btnResvcheckin;
        private Button btnUPloadRMKey;
        private Button btnGetaccnumtbyrm;
        private Button btnGetcheckoutfolio;
        private Button buttonX7;
        private Button btnSetup;
    }
}