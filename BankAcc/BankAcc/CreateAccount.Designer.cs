namespace BankAcc
{
    partial class CreateAccount
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
            this.custidlb = new System.Windows.Forms.Label();
            this.AcctNumberlb = new System.Windows.Forms.Label();
            this.Typelb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxAcct = new System.Windows.Forms.TextBox();
            this.textBoxBal = new System.Windows.Forms.TextBox();
            this.ComboBoxType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Createbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // custidlb
            // 
            this.custidlb.AutoSize = true;
            this.custidlb.Location = new System.Drawing.Point(6, 39);
            this.custidlb.Name = "custidlb";
            this.custidlb.Size = new System.Drawing.Size(65, 13);
            this.custidlb.TabIndex = 0;
            this.custidlb.Text = "Customer ID";
            this.custidlb.Click += new System.EventHandler(this.custidlb_Click);
            // 
            // AcctNumberlb
            // 
            this.AcctNumberlb.AutoSize = true;
            this.AcctNumberlb.Location = new System.Drawing.Point(6, 79);
            this.AcctNumberlb.Name = "AcctNumberlb";
            this.AcctNumberlb.Size = new System.Drawing.Size(60, 13);
            this.AcctNumberlb.TabIndex = 1;
            this.AcctNumberlb.Text = "Account #:";
            this.AcctNumberlb.Click += new System.EventHandler(this.AcctNumberlb_Click);
            // 
            // Typelb
            // 
            this.Typelb.AutoSize = true;
            this.Typelb.Location = new System.Drawing.Point(32, 117);
            this.Typelb.Name = "Typelb";
            this.Typelb.Size = new System.Drawing.Size(34, 13);
            this.Typelb.TabIndex = 2;
            this.Typelb.Text = "Type:";
            this.Typelb.Click += new System.EventHandler(this.Typelb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balance:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(77, 32);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.ReadOnly = true;
            this.textBoxid.Size = new System.Drawing.Size(63, 20);
            this.textBoxid.TabIndex = 4;
            this.textBoxid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxAcct
            // 
            this.textBoxAcct.Location = new System.Drawing.Point(77, 72);
            this.textBoxAcct.Name = "textBoxAcct";
            this.textBoxAcct.Size = new System.Drawing.Size(77, 20);
            this.textBoxAcct.TabIndex = 5;
            this.textBoxAcct.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxBal
            // 
            this.textBoxBal.Location = new System.Drawing.Point(77, 147);
            this.textBoxBal.Name = "textBoxBal";
            this.textBoxBal.Size = new System.Drawing.Size(77, 20);
            this.textBoxBal.TabIndex = 7;
            this.textBoxBal.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Items.AddRange(new object[] {
            "MMA",
            "CHK",
            "SAV"});
            this.ComboBoxType.Location = new System.Drawing.Point(77, 109);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(63, 21);
            this.ComboBoxType.TabIndex = 8;
            this.ComboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Createbtn);
            this.groupBox1.Controls.Add(this.custidlb);
            this.groupBox1.Controls.Add(this.textBoxBal);
            this.groupBox1.Controls.Add(this.ComboBoxType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxid);
            this.groupBox1.Controls.Add(this.AcctNumberlb);
            this.groupBox1.Controls.Add(this.textBoxAcct);
            this.groupBox1.Controls.Add(this.Typelb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 247);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            // 
            // Createbtn
            // 
            this.Createbtn.Location = new System.Drawing.Point(20, 194);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(134, 30);
            this.Createbtn.TabIndex = 9;
            this.Createbtn.Text = "Create";
            this.Createbtn.UseVisualStyleBackColor = true;
            this.Createbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 287);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label custidlb;
        private System.Windows.Forms.Label AcctNumberlb;
        private System.Windows.Forms.Label Typelb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxAcct;
        private System.Windows.Forms.TextBox textBoxBal;
        private System.Windows.Forms.ComboBox ComboBoxType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Createbtn;
    }
}