namespace BankAcc
{
    partial class CreateCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Createbtn = new System.Windows.Forms.Button();
            this.textBoxcid = new System.Windows.Forms.TextBox();
            this.Custidlb = new System.Windows.Forms.Label();
            this.textBoxPw = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.Passwordlb = new System.Windows.Forms.Label();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Addresslb = new System.Windows.Forms.Label();
            this.lastNamelb = new System.Windows.Forms.Label();
            this.Fnamelb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxcid);
            this.groupBox1.Controls.Add(this.Custidlb);
            this.groupBox1.Controls.Add(this.textBoxPw);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxaddress);
            this.groupBox1.Controls.Add(this.textBoxLname);
            this.groupBox1.Controls.Add(this.Passwordlb);
            this.groupBox1.Controls.Add(this.textBoxFname);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.Addresslb);
            this.groupBox1.Controls.Add(this.lastNamelb);
            this.groupBox1.Controls.Add(this.Fnamelb);
            this.groupBox1.Controls.Add(this.Createbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 220);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // Createbtn
            // 
            this.Createbtn.Location = new System.Drawing.Point(142, 167);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(164, 30);
            this.Createbtn.TabIndex = 9;
            this.Createbtn.Text = "Create Customer";
            this.Createbtn.UseVisualStyleBackColor = true;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // textBoxcid
            // 
            this.textBoxcid.Location = new System.Drawing.Point(78, 29);
            this.textBoxcid.Name = "textBoxcid";
            this.textBoxcid.Size = new System.Drawing.Size(100, 20);
            this.textBoxcid.TabIndex = 31;
            // 
            // Custidlb
            // 
            this.Custidlb.AutoSize = true;
            this.Custidlb.Location = new System.Drawing.Point(9, 33);
            this.Custidlb.Name = "Custidlb";
            this.Custidlb.Size = new System.Drawing.Size(66, 13);
            this.Custidlb.TabIndex = 30;
            this.Custidlb.Text = "Customer Id:";
            // 
            // textBoxPw
            // 
            this.textBoxPw.Location = new System.Drawing.Point(284, 29);
            this.textBoxPw.Name = "textBoxPw";
            this.textBoxPw.Size = new System.Drawing.Size(123, 20);
            this.textBoxPw.TabIndex = 29;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(283, 117);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(124, 20);
            this.textBoxEmail.TabIndex = 28;
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.Location = new System.Drawing.Point(78, 116);
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxaddress.TabIndex = 19;
            // 
            // textBoxLname
            // 
            this.textBoxLname.Location = new System.Drawing.Point(283, 71);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(124, 20);
            this.textBoxLname.TabIndex = 21;
            // 
            // Passwordlb
            // 
            this.Passwordlb.AutoSize = true;
            this.Passwordlb.Location = new System.Drawing.Point(221, 33);
            this.Passwordlb.Name = "Passwordlb";
            this.Passwordlb.Size = new System.Drawing.Size(56, 13);
            this.Passwordlb.TabIndex = 27;
            this.Passwordlb.Text = "Password:";
            // 
            // textBoxFname
            // 
            this.textBoxFname.Location = new System.Drawing.Point(78, 69);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(100, 20);
            this.textBoxFname.TabIndex = 24;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(239, 122);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 26;
            this.Email.Text = "Email:";
            // 
            // Addresslb
            // 
            this.Addresslb.AutoSize = true;
            this.Addresslb.Location = new System.Drawing.Point(20, 122);
            this.Addresslb.Name = "Addresslb";
            this.Addresslb.Size = new System.Drawing.Size(48, 13);
            this.Addresslb.TabIndex = 20;
            this.Addresslb.Text = "Address:";
            // 
            // lastNamelb
            // 
            this.lastNamelb.AutoSize = true;
            this.lastNamelb.Location = new System.Drawing.Point(216, 76);
            this.lastNamelb.Name = "lastNamelb";
            this.lastNamelb.Size = new System.Drawing.Size(61, 13);
            this.lastNamelb.TabIndex = 22;
            this.lastNamelb.Text = "Last Name:";
            // 
            // Fnamelb
            // 
            this.Fnamelb.AutoSize = true;
            this.Fnamelb.Location = new System.Drawing.Point(15, 73);
            this.Fnamelb.Name = "Fnamelb";
            this.Fnamelb.Size = new System.Drawing.Size(60, 13);
            this.Fnamelb.TabIndex = 25;
            this.Fnamelb.Text = "First Name:";
            // 
            // CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 253);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateCustomer";
            this.Text = "CreateCustomer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.TextBox textBoxcid;
        private System.Windows.Forms.Label Custidlb;
        private System.Windows.Forms.TextBox textBoxPw;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.Label Passwordlb;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Addresslb;
        private System.Windows.Forms.Label lastNamelb;
        private System.Windows.Forms.Label Fnamelb;
    }
}