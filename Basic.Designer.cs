﻿namespace CrystisDesktopNet
{
    partial class frmBasic
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsCustomers = new System.Data.DataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGetReportUrl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(374, 170);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 83;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(5, 16);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(444, 133);
            this.DataGridView1.TabIndex = 82;
            // 
            // dsCustomers
            // 
            this.dsCustomers.DataSetName = "dsCustomers";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 200);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 88);
            this.textBox1.TabIndex = 87;
            // 
            // btnGetReportUrl
            // 
            this.btnGetReportUrl.Location = new System.Drawing.Point(12, 170);
            this.btnGetReportUrl.Name = "btnGetReportUrl";
            this.btnGetReportUrl.Size = new System.Drawing.Size(101, 23);
            this.btnGetReportUrl.TabIndex = 86;
            this.btnGetReportUrl.Text = "Get Report Url";
            this.btnGetReportUrl.UseVisualStyleBackColor = true;
            this.btnGetReportUrl.Click += new System.EventHandler(this.btnGetReportUrl_Click);
            // 
            // frmBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 298);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGetReportUrl);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.DataGridView1);
            this.Name = "frmBasic";
            this.Text = "Basic";
            this.Load += new System.EventHandler(this.frmBasic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private System.Data.DataSet dsCustomers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGetReportUrl;
    }
}