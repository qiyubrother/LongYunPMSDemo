using System.Windows.Forms;

namespace LongYunPMSDemo.Views
{
    partial class FrmTimestamp
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
            this.components = new System.ComponentModel.Container();
            this.btnAction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseURL = new TextBox();
            this.txtRequiredURL = new TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMethod = new TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtURL = new TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnComputeURL = new System.Windows.Forms.Button();
            this.textBoxX2 = new TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.LightGreen;
            this.btnAction.Location = new System.Drawing.Point(94, 160);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(164, 34);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "获取服务器时间戳";
            this.btnAction.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "基地址";
            // 
            // txtBaseURL
            // 
            this.txtBaseURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBaseURL.Location = new System.Drawing.Point(94, 12);
            this.txtBaseURL.Name = "txtBaseURL";
            this.txtBaseURL.ReadOnly = true;
            this.txtBaseURL.Size = new System.Drawing.Size(919, 21);
            this.txtBaseURL.TabIndex = 3;
            // 
            // txtRequiredURL
            // 
            this.txtRequiredURL.Location = new System.Drawing.Point(94, 39);
            this.txtRequiredURL.Name = "txtRequiredURL";
            this.txtRequiredURL.ReadOnly = true;
            this.txtRequiredURL.Size = new System.Drawing.Size(919, 21);
            this.txtRequiredURL.TabIndex = 7;
            this.txtRequiredURL.Text = "/timestamp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "请求地址";
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(94, 66);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.ReadOnly = true;
            this.txtMethod.Size = new System.Drawing.Size(100, 21);
            this.txtMethod.TabIndex = 14;
            this.txtMethod.Text = "GET";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "请求方式";
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(94, 93);
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = true;
            this.txtURL.Size = new System.Drawing.Size(919, 21);
            this.txtURL.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "完整请求地址";
            // 
            // btnComputeURL
            // 
            this.btnComputeURL.Location = new System.Drawing.Point(94, 120);
            this.btnComputeURL.Name = "btnComputeURL";
            this.btnComputeURL.Size = new System.Drawing.Size(164, 34);
            this.btnComputeURL.TabIndex = 17;
            this.btnComputeURL.Text = "计算完整请求地址";
            this.btnComputeURL.UseVisualStyleBackColor = true;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX2.Location = new System.Drawing.Point(94, 200);
            this.textBoxX2.Multiline = true;
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.ReadOnly = true;
            this.textBoxX2.Size = new System.Drawing.Size(919, 197);
            this.textBoxX2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "请求结果";
            // 
            // FrmTimestamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 409);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.btnComputeURL);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRequiredURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBaseURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAction);
            this.Name = "FrmTimestamp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "获取服务器时间戳";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label1;
        private TextBox txtBaseURL;
        private TextBox txtRequiredURL;
        private System.Windows.Forms.Label label4;
        private TextBox txtMethod;
        private System.Windows.Forms.Label label7;
        private TextBox txtURL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnComputeURL;
        private TextBox textBoxX2;
        private System.Windows.Forms.Label label2;
    }
}