namespace LongYunPMSDemo.Views
{
    partial class FrmResvList
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
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRequiredURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaseURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.txtHotelId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartnerId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtResvnum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(94, 268);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(919, 264);
            this.txtResult.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "请求结果";
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(94, 66);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.ReadOnly = true;
            this.txtMethod.Size = new System.Drawing.Size(227, 21);
            this.txtMethod.TabIndex = 25;
            this.txtMethod.Text = "GET";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "请求方式";
            // 
            // txtRequiredURL
            // 
            this.txtRequiredURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequiredURL.Location = new System.Drawing.Point(94, 39);
            this.txtRequiredURL.Name = "txtRequiredURL";
            this.txtRequiredURL.ReadOnly = true;
            this.txtRequiredURL.Size = new System.Drawing.Size(919, 21);
            this.txtRequiredURL.TabIndex = 23;
            this.txtRequiredURL.Text = "/resvlist?partner_id={PartnerId}&hotel_code={HotelCode}&timestamp={timestamp}&sec" +
    "ret={secret}&name={name}&mobile={mobile}&resvnum={resvnum}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "请求地址";
            // 
            // txtBaseURL
            // 
            this.txtBaseURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBaseURL.Location = new System.Drawing.Point(94, 12);
            this.txtBaseURL.Name = "txtBaseURL";
            this.txtBaseURL.ReadOnly = true;
            this.txtBaseURL.Size = new System.Drawing.Size(919, 21);
            this.txtBaseURL.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "基地址";
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.LightGreen;
            this.btnAction.Location = new System.Drawing.Point(94, 228);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(164, 34);
            this.btnAction.TabIndex = 19;
            this.btnAction.Text = "预定查询";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // txtHotelId
            // 
            this.txtHotelId.Location = new System.Drawing.Point(94, 120);
            this.txtHotelId.Name = "txtHotelId";
            this.txtHotelId.ReadOnly = true;
            this.txtHotelId.Size = new System.Drawing.Size(227, 21);
            this.txtHotelId.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "hotel_code";
            // 
            // txtPartnerId
            // 
            this.txtPartnerId.Location = new System.Drawing.Point(94, 93);
            this.txtPartnerId.Name = "txtPartnerId";
            this.txtPartnerId.ReadOnly = true;
            this.txtPartnerId.Size = new System.Drawing.Size(227, 21);
            this.txtPartnerId.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "partner_id";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(94, 174);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(227, 21);
            this.txtMobile.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 37;
            this.label6.Text = "mobile 手机号";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 147);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 21);
            this.txtName.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "name 姓名";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 37;
            this.label10.Text = "resvnum 预定号";
            // 
            // txtResvnum
            // 
            this.txtResvnum.Location = new System.Drawing.Point(94, 201);
            this.txtResvnum.Name = "txtResvnum";
            this.txtResvnum.Size = new System.Drawing.Size(227, 21);
            this.txtResvnum.TabIndex = 38;
            // 
            // FrmResvList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 544);
            this.Controls.Add(this.txtResvnum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHotelId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPartnerId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRequiredURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBaseURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAction);
            this.Name = "FrmResvList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预定查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRequiredURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBaseURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox txtHotelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartnerId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtResvnum;
    }
}