namespace CrystisDesktopNet
{
    partial class frmFull
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtPaper = new System.Windows.Forms.RadioButton();
            this.rbtScreen = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAscDesc = new System.Windows.Forms.Label();
            this.lblColumn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFormula = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rbtPaper);
            this.GroupBox1.Controls.Add(this.rbtScreen);
            this.GroupBox1.Location = new System.Drawing.Point(12, 160);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(202, 66);
            this.GroupBox1.TabIndex = 157;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Destination";
            // 
            // rbtPaper
            // 
            this.rbtPaper.AutoSize = true;
            this.rbtPaper.Location = new System.Drawing.Point(14, 41);
            this.rbtPaper.Name = "rbtPaper";
            this.rbtPaper.Size = new System.Drawing.Size(67, 17);
            this.rbtPaper.TabIndex = 1;
            this.rbtPaper.Text = "on paper";
            this.rbtPaper.UseVisualStyleBackColor = true;
            // 
            // rbtScreen
            // 
            this.rbtScreen.AutoSize = true;
            this.rbtScreen.Checked = true;
            this.rbtScreen.Location = new System.Drawing.Point(14, 20);
            this.rbtScreen.Name = "rbtScreen";
            this.rbtScreen.Size = new System.Drawing.Size(72, 17);
            this.rbtScreen.TabIndex = 0;
            this.rbtScreen.TabStop = true;
            this.rbtScreen.Text = "on screen";
            this.rbtScreen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 156;
            this.label3.Text = "Direction:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 155;
            this.label2.Text = "Column:";
            // 
            // lblAscDesc
            // 
            this.lblAscDesc.AutoSize = true;
            this.lblAscDesc.ForeColor = System.Drawing.Color.Blue;
            this.lblAscDesc.Location = new System.Drawing.Point(76, 272);
            this.lblAscDesc.Name = "lblAscDesc";
            this.lblAscDesc.Size = new System.Drawing.Size(60, 13);
            this.lblAscDesc.TabIndex = 154;
            this.lblAscDesc.Text = "lblAscDesc";
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.ForeColor = System.Drawing.Color.Blue;
            this.lblColumn.Location = new System.Drawing.Point(76, 257);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(52, 13);
            this.lblColumn.TabIndex = 153;
            this.lblColumn.Text = "lblColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 152;
            this.label1.Text = "Sort:";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(381, 241);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 151;
            this.Button1.Text = "Print";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(12, 12);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(444, 133);
            this.DataGridView1.TabIndex = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkFormula);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(220, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 66);
            this.groupBox2.TabIndex = 158;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formula";
            // 
            // chkFormula
            // 
            this.chkFormula.AutoSize = true;
            this.chkFormula.Location = new System.Drawing.Point(21, 38);
            this.chkFormula.Name = "chkFormula";
            this.chkFormula.Size = new System.Drawing.Size(97, 17);
            this.chkFormula.TabIndex = 1;
            this.chkFormula.Text = "include formula";
            this.chkFormula.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Country = Germany";
            // 
            // frmFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 307);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAscDesc);
            this.Controls.Add(this.lblColumn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmFull";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmFull_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.RadioButton rbtPaper;
        private System.Windows.Forms.RadioButton rbtScreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAscDesc;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkFormula;
        private System.Windows.Forms.Label label4;
    }
}