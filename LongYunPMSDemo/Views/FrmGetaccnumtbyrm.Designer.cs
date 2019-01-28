namespace LongYunPMSDemo
{
    partial class FrmGetaccnumtbyrm
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
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHotelId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartnerId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRequiredURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaseURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCertNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(143, 174);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(227, 21);
            this.txtMobile.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 72;
            this.label6.Text = "Mobile  手机号";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Location = new System.Drawing.Point(143, 147);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(227, 21);
            this.txtRoomNum.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 70;
            this.label9.Text = "RoomNum  房间号";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtHotelId
            // 
            this.txtHotelId.Location = new System.Drawing.Point(143, 120);
            this.txtHotelId.Name = "txtHotelId";
            this.txtHotelId.ReadOnly = true;
            this.txtHotelId.Size = new System.Drawing.Size(227, 21);
            this.txtHotelId.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 68;
            this.label3.Text = "hotel_code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPartnerId
            // 
            this.txtPartnerId.Location = new System.Drawing.Point(143, 93);
            this.txtPartnerId.Name = "txtPartnerId";
            this.txtPartnerId.ReadOnly = true;
            this.txtPartnerId.Size = new System.Drawing.Size(227, 21);
            this.txtPartnerId.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 66;
            this.label5.Text = "partner_id";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(143, 268);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(978, 291);
            this.txtResult.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 64;
            this.label2.Text = "请求结果";
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(143, 66);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.ReadOnly = true;
            this.txtMethod.Size = new System.Drawing.Size(227, 21);
            this.txtMethod.TabIndex = 63;
            this.txtMethod.Text = "GET";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 62;
            this.label7.Text = "请求方式";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRequiredURL
            // 
            this.txtRequiredURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequiredURL.Location = new System.Drawing.Point(143, 39);
            this.txtRequiredURL.Name = "txtRequiredURL";
            this.txtRequiredURL.ReadOnly = true;
            this.txtRequiredURL.Size = new System.Drawing.Size(978, 21);
            this.txtRequiredURL.TabIndex = 61;
            this.txtRequiredURL.Text = "/getaccnumtbyrm?partner_id={partner_id}&hotel_code={hotel_code}&timestamp={timest" +
    "amp}&secret={secret}&roomnum={roomnum}&mobile={mobile}&certnum={certnum}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 60;
            this.label4.Text = "请求地址";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBaseURL
            // 
            this.txtBaseURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBaseURL.Location = new System.Drawing.Point(143, 12);
            this.txtBaseURL.Name = "txtBaseURL";
            this.txtBaseURL.ReadOnly = true;
            this.txtBaseURL.Size = new System.Drawing.Size(978, 21);
            this.txtBaseURL.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 58;
            this.label1.Text = "基地址";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.LightGreen;
            this.btnAction.Location = new System.Drawing.Point(143, 228);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(164, 34);
            this.btnAction.TabIndex = 57;
            this.btnAction.Text = "查询";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 12);
            this.label8.TabIndex = 72;
            this.label8.Text = "CertNum  证件号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCertNum
            // 
            this.txtCertNum.Location = new System.Drawing.Point(143, 201);
            this.txtCertNum.Name = "txtCertNum";
            this.txtCertNum.Size = new System.Drawing.Size(227, 21);
            this.txtCertNum.TabIndex = 73;
            // 
            // FrmGetaccnumtbyrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 571);
            this.Controls.Add(this.txtCertNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRoomNum);
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
            this.Name = "FrmGetaccnumtbyrm";
            this.Text = "查询在店客人账号";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHotelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartnerId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRequiredURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBaseURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCertNum;
    }
}