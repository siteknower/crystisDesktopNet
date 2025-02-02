namespace CrystisDesktopNet
{
    partial class Main
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
            this.btnBasic = new System.Windows.Forms.Button();
            this.btnFull = new System.Windows.Forms.Button();
            this.panelFrame = new System.Windows.Forms.Panel();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBasic
            // 
            this.btnBasic.BackColor = System.Drawing.Color.Transparent;
            this.btnBasic.FlatAppearance.BorderSize = 0;
            this.btnBasic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasic.Location = new System.Drawing.Point(13, 13);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Size = new System.Drawing.Size(45, 22);
            this.btnBasic.TabIndex = 0;
            this.btnBasic.Text = "Basic";
            this.btnBasic.UseVisualStyleBackColor = false;
            this.btnBasic.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // btnFull
            // 
            this.btnFull.FlatAppearance.BorderSize = 0;
            this.btnFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFull.Location = new System.Drawing.Point(58, 13);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(38, 23);
            this.btnFull.TabIndex = 1;
            this.btnFull.Text = "Full";
            this.btnFull.UseVisualStyleBackColor = true;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // panelFrame
            // 
            this.panelFrame.Location = new System.Drawing.Point(20, 40);
            this.panelFrame.Name = "panelFrame";
            this.panelFrame.Size = new System.Drawing.Size(476, 306);
            this.panelFrame.TabIndex = 2;
            // 
            // btnInvoice
            // 
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Location = new System.Drawing.Point(99, 12);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(50, 23);
            this.btnInvoice.TabIndex = 4;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 2);
            this.label1.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.panelFrame);
            this.Controls.Add(this.btnFull);
            this.Controls.Add(this.btnBasic);
            this.Name = "Main";
            this.Text = "Desktop Net Siteknower";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBasic;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Panel panelFrame;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Label label1;
    }
}

