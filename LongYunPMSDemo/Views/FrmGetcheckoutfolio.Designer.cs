namespace LongYunPMSDemo
{
    partial class FrmGetcheckoutfolio
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.txtPMSAccountNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHotelId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartnerId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRequiredURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaseURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(110, 214);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(763, 265);
            this.txtResult.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 82;
            this.label2.Text = "请求结果";
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.LightGreen;
            this.btnAction.Location = new System.Drawing.Point(110, 174);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(164, 34);
            this.btnAction.TabIndex = 81;
            this.btnAction.Text = "获取结账账单";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // txtPMSAccountNum
            // 
            this.txtPMSAccountNum.Location = new System.Drawing.Point(108, 147);
            this.txtPMSAccountNum.Name = "txtPMSAccountNum";
            this.txtPMSAccountNum.Size = new System.Drawing.Size(227, 21);
            this.txtPMSAccountNum.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 79;
            this.label9.Text = "acctnum PMS账号";
            // 
            // txtHotelId
            // 
            this.txtHotelId.Location = new System.Drawing.Point(108, 120);
            this.txtHotelId.Name = "txtHotelId";
            this.txtHotelId.ReadOnly = true;
            this.txtHotelId.Size = new System.Drawing.Size(227, 21);
            this.txtHotelId.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 77;
            this.label3.Text = "hotel_code";
            // 
            // txtPartnerId
            // 
            this.txtPartnerId.Location = new System.Drawing.Point(108, 93);
            this.txtPartnerId.Name = "txtPartnerId";
            this.txtPartnerId.ReadOnly = true;
            this.txtPartnerId.Size = new System.Drawing.Size(227, 21);
            this.txtPartnerId.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 75;
            this.label5.Text = "partner_id";
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(108, 66);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.ReadOnly = true;
            this.txtMethod.Size = new System.Drawing.Size(227, 21);
            this.txtMethod.TabIndex = 74;
            this.txtMethod.Text = "POST";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 73;
            this.label7.Text = "请求方式";
            // 
            // txtRequiredURL
            // 
            this.txtRequiredURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequiredURL.Location = new System.Drawing.Point(110, 39);
            this.txtRequiredURL.Name = "txtRequiredURL";
            this.txtRequiredURL.ReadOnly = true;
            this.txtRequiredURL.Size = new System.Drawing.Size(763, 21);
            this.txtRequiredURL.TabIndex = 72;
            this.txtRequiredURL.Text = "/resvcheckin?partner_id={partner_id}&hotel_code={hotel_code}&timestamp={timestamp" +
    "}&secret={secret}&acctnum={acctnum}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 71;
            this.label4.Text = "请求地址";
            // 
            // txtBaseURL
            // 
            this.txtBaseURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBaseURL.Location = new System.Drawing.Point(108, 12);
            this.txtBaseURL.Name = "txtBaseURL";
            this.txtBaseURL.ReadOnly = true;
            this.txtBaseURL.Size = new System.Drawing.Size(765, 21);
            this.txtBaseURL.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 69;
            this.label1.Text = "基地址";
            // 
            // FrmGetcheckoutfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 491);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtPMSAccountNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHotelId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPartnerId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRequiredURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBaseURL);
            this.Controls.Add(this.label1);
            this.Name = "FrmGetcheckoutfolio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "获取结账账单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox txtPMSAccountNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHotelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartnerId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRequiredURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBaseURL;
        private System.Windows.Forms.Label label1;
    }
}