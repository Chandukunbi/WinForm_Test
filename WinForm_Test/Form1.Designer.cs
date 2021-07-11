
namespace WinForm_Test
{
    partial class Form1
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
            this.cmbOtherApps = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listKeys = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listSendKeys = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInputToOtherApp = new System.Windows.Forms.Button();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOtherApps
            // 
            this.cmbOtherApps.FormattingEnabled = true;
            this.cmbOtherApps.Location = new System.Drawing.Point(26, 25);
            this.cmbOtherApps.Name = "cmbOtherApps";
            this.cmbOtherApps.Size = new System.Drawing.Size(728, 21);
            this.cmbOtherApps.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Other Apps :";
            // 
            // listKeys
            // 
            this.listKeys.FormattingEnabled = true;
            this.listKeys.Location = new System.Drawing.Point(26, 88);
            this.listKeys.Name = "listKeys";
            this.listKeys.Size = new System.Drawing.Size(308, 290);
            this.listKeys.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Keys :";
            // 
            // listSendKeys
            // 
            this.listSendKeys.FormattingEnabled = true;
            this.listSendKeys.Location = new System.Drawing.Point(446, 88);
            this.listSendKeys.Name = "listSendKeys";
            this.listSendKeys.Size = new System.Drawing.Size(308, 290);
            this.listSendKeys.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(672, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Reload App List";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(365, 180);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(26, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Add";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(365, 236);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(38, 13);
            this.linkLabel3.TabIndex = 7;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Delete";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(149, 407);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInputToOtherApp
            // 
            this.btnInputToOtherApp.Location = new System.Drawing.Point(511, 384);
            this.btnInputToOtherApp.Name = "btnInputToOtherApp";
            this.btnInputToOtherApp.Size = new System.Drawing.Size(132, 46);
            this.btnInputToOtherApp.TabIndex = 9;
            this.btnInputToOtherApp.Text = "Send Keyboard Input to Other App";
            this.btnInputToOtherApp.UseVisualStyleBackColor = true;
            this.btnInputToOtherApp.Click += new System.EventHandler(this.btnInputToOtherApp_Click);
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(511, 439);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(132, 41);
            this.btnSimulate.TabIndex = 10;
            this.btnSimulate.Text = "Simulate Customer Res";
            this.btnSimulate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Keys to Send to Other Apps :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.btnInputToOtherApp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.listSendKeys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listKeys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOtherApps);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Keyboard Input to Other Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOtherApps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listKeys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listSendKeys;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInputToOtherApp;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Label label3;
    }
}

