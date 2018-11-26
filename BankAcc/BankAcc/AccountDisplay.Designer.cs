namespace BankAcc
{
    partial class AccountDisplay
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
            this.fullnamelb = new System.Windows.Forms.Label();
            this.hello = new System.Windows.Forms.Label();
            this.ViewAccountbtn = new System.Windows.Forms.Button();
            this.Emaillb = new System.Windows.Forms.Label();
            this.PersonalInfo = new System.Windows.Forms.Button();
            this.Custidtb = new System.Windows.Forms.TextBox();
            this.Nametb = new System.Windows.Forms.TextBox();
            this.Emailtb = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewer = new System.Windows.Forms.ListView();
            this.Depositbtn = new System.Windows.Forms.Button();
            this.Withdrawlbtn = new System.Windows.Forms.Button();
            this.Addresslb = new System.Windows.Forms.Label();
            this.lastNamelb = new System.Windows.Forms.Label();
            this.Fnamelb = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxcid = new System.Windows.Forms.TextBox();
            this.Custidlb = new System.Windows.Forms.Label();
            this.textBoxPw = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.Passwordlb = new System.Windows.Forms.Label();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.upDatebtn = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullnamelb
            // 
            this.fullnamelb.AutoSize = true;
            this.fullnamelb.Location = new System.Drawing.Point(18, 53);
            this.fullnamelb.Name = "fullnamelb";
            this.fullnamelb.Size = new System.Drawing.Size(38, 13);
            this.fullnamelb.TabIndex = 0;
            this.fullnamelb.Text = "Name:";
            this.fullnamelb.Click += new System.EventHandler(this.fullnamelb_Click);
            // 
            // hello
            // 
            this.hello.AutoSize = true;
            this.hello.Location = new System.Drawing.Point(18, 26);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(19, 13);
            this.hello.TabIndex = 1;
            this.hello.Text = "Id:";
            // 
            // ViewAccountbtn
            // 
            this.ViewAccountbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAccountbtn.Location = new System.Drawing.Point(291, 61);
            this.ViewAccountbtn.Name = "ViewAccountbtn";
            this.ViewAccountbtn.Size = new System.Drawing.Size(107, 34);
            this.ViewAccountbtn.TabIndex = 2;
            this.ViewAccountbtn.Text = "View Accounts";
            this.ViewAccountbtn.UseVisualStyleBackColor = true;
            this.ViewAccountbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Emaillb
            // 
            this.Emaillb.AutoSize = true;
            this.Emaillb.Location = new System.Drawing.Point(18, 82);
            this.Emaillb.Name = "Emaillb";
            this.Emaillb.Size = new System.Drawing.Size(32, 13);
            this.Emaillb.TabIndex = 3;
            this.Emaillb.Text = "Email";
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalInfo.Location = new System.Drawing.Point(291, 19);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Size = new System.Drawing.Size(107, 34);
            this.PersonalInfo.TabIndex = 4;
            this.PersonalInfo.Text = "Edit Profile";
            this.PersonalInfo.UseVisualStyleBackColor = true;
            this.PersonalInfo.Click += new System.EventHandler(this.PersonalInfo_Click);
            // 
            // Custidtb
            // 
            this.Custidtb.Location = new System.Drawing.Point(72, 19);
            this.Custidtb.Name = "Custidtb";
            this.Custidtb.ReadOnly = true;
            this.Custidtb.Size = new System.Drawing.Size(65, 20);
            this.Custidtb.TabIndex = 5;
            // 
            // Nametb
            // 
            this.Nametb.Location = new System.Drawing.Point(72, 46);
            this.Nametb.Name = "Nametb";
            this.Nametb.ReadOnly = true;
            this.Nametb.Size = new System.Drawing.Size(196, 20);
            this.Nametb.TabIndex = 6;
            // 
            // Emailtb
            // 
            this.Emailtb.Location = new System.Drawing.Point(72, 75);
            this.Emailtb.Name = "Emailtb";
            this.Emailtb.ReadOnly = true;
            this.Emailtb.Size = new System.Drawing.Size(196, 20);
            this.Emailtb.TabIndex = 7;
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(428, 19);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(105, 76);
            this.Create.TabIndex = 8;
            this.Create.Text = "Create Account";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.PersonalInfo);
            this.groupBox.Controls.Add(this.Create);
            this.groupBox.Controls.Add(this.fullnamelb);
            this.groupBox.Controls.Add(this.Emailtb);
            this.groupBox.Controls.Add(this.hello);
            this.groupBox.Controls.Add(this.Nametb);
            this.groupBox.Controls.Add(this.ViewAccountbtn);
            this.groupBox.Controls.Add(this.Custidtb);
            this.groupBox.Controls.Add(this.Emaillb);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(543, 122);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Customer Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listViewer
            // 
            this.listViewer.Location = new System.Drawing.Point(0, 14);
            this.listViewer.Name = "listViewer";
            this.listViewer.Size = new System.Drawing.Size(401, 123);
            this.listViewer.TabIndex = 10;
            this.listViewer.UseCompatibleStateImageBehavior = false;
            this.listViewer.Visible = false;
            // 
            // Depositbtn
            // 
            this.Depositbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depositbtn.Location = new System.Drawing.Point(426, 21);
            this.Depositbtn.Name = "Depositbtn";
            this.Depositbtn.Size = new System.Drawing.Size(107, 46);
            this.Depositbtn.TabIndex = 11;
            this.Depositbtn.Text = "Deposit";
            this.Depositbtn.UseVisualStyleBackColor = true;
            this.Depositbtn.Visible = false;
            this.Depositbtn.Click += new System.EventHandler(this.Depositbtn_Click);
            // 
            // Withdrawlbtn
            // 
            this.Withdrawlbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdrawlbtn.Location = new System.Drawing.Point(426, 86);
            this.Withdrawlbtn.Name = "Withdrawlbtn";
            this.Withdrawlbtn.Size = new System.Drawing.Size(107, 44);
            this.Withdrawlbtn.TabIndex = 12;
            this.Withdrawlbtn.Text = "Withdrawl";
            this.Withdrawlbtn.UseVisualStyleBackColor = true;
            this.Withdrawlbtn.Visible = false;
            this.Withdrawlbtn.Click += new System.EventHandler(this.Withdrawlbtn_Click);
            // 
            // Addresslb
            // 
            this.Addresslb.AutoSize = true;
            this.Addresslb.Location = new System.Drawing.Point(14, 117);
            this.Addresslb.Name = "Addresslb";
            this.Addresslb.Size = new System.Drawing.Size(48, 13);
            this.Addresslb.TabIndex = 9;
            this.Addresslb.Text = "Address:";
            // 
            // lastNamelb
            // 
            this.lastNamelb.AutoSize = true;
            this.lastNamelb.Location = new System.Drawing.Point(210, 71);
            this.lastNamelb.Name = "lastNamelb";
            this.lastNamelb.Size = new System.Drawing.Size(61, 13);
            this.lastNamelb.TabIndex = 10;
            this.lastNamelb.Text = "Last Name:";
            // 
            // Fnamelb
            // 
            this.Fnamelb.AutoSize = true;
            this.Fnamelb.Location = new System.Drawing.Point(9, 68);
            this.Fnamelb.Name = "Fnamelb";
            this.Fnamelb.Size = new System.Drawing.Size(60, 13);
            this.Fnamelb.TabIndex = 11;
            this.Fnamelb.Text = "First Name:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(233, 117);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 13;
            this.Email.Text = "Email:";
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
            this.groupBox1.Controls.Add(this.Depositbtn);
            this.groupBox1.Controls.Add(this.Addresslb);
            this.groupBox1.Controls.Add(this.Withdrawlbtn);
            this.groupBox1.Controls.Add(this.lastNamelb);
            this.groupBox1.Controls.Add(this.Fnamelb);
            this.groupBox1.Controls.Add(this.listViewer);
            this.groupBox1.Controls.Add(this.upDatebtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 167);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Detail Below";
            // 
            // textBoxcid
            // 
            this.textBoxcid.Location = new System.Drawing.Point(72, 21);
            this.textBoxcid.Name = "textBoxcid";
            this.textBoxcid.ReadOnly = true;
            this.textBoxcid.Size = new System.Drawing.Size(100, 20);
            this.textBoxcid.TabIndex = 18;
            // 
            // Custidlb
            // 
            this.Custidlb.AutoSize = true;
            this.Custidlb.Location = new System.Drawing.Point(3, 28);
            this.Custidlb.Name = "Custidlb";
            this.Custidlb.Size = new System.Drawing.Size(66, 13);
            this.Custidlb.TabIndex = 17;
            this.Custidlb.Text = "Customer Id:";
            // 
            // textBoxPw
            // 
            this.textBoxPw.Location = new System.Drawing.Point(278, 21);
            this.textBoxPw.Name = "textBoxPw";
            this.textBoxPw.Size = new System.Drawing.Size(123, 20);
            this.textBoxPw.TabIndex = 16;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(277, 110);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(124, 20);
            this.textBoxEmail.TabIndex = 15;
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.Location = new System.Drawing.Point(72, 110);
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxaddress.TabIndex = 9;
            // 
            // textBoxLname
            // 
            this.textBoxLname.Location = new System.Drawing.Point(277, 65);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(124, 20);
            this.textBoxLname.TabIndex = 10;
            // 
            // Passwordlb
            // 
            this.Passwordlb.AutoSize = true;
            this.Passwordlb.Location = new System.Drawing.Point(215, 28);
            this.Passwordlb.Name = "Passwordlb";
            this.Passwordlb.Size = new System.Drawing.Size(56, 13);
            this.Passwordlb.TabIndex = 14;
            this.Passwordlb.Text = "Password:";
            // 
            // textBoxFname
            // 
            this.textBoxFname.Location = new System.Drawing.Point(72, 64);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(100, 20);
            this.textBoxFname.TabIndex = 11;
            // 
            // upDatebtn
            // 
            this.upDatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDatebtn.Location = new System.Drawing.Point(428, 35);
            this.upDatebtn.Name = "upDatebtn";
            this.upDatebtn.Size = new System.Drawing.Size(105, 76);
            this.upDatebtn.TabIndex = 19;
            this.upDatebtn.Text = "Update Info";
            this.upDatebtn.UseVisualStyleBackColor = true;
            this.upDatebtn.Click += new System.EventHandler(this.upDatebtn_Click);
            // 
            // AccountDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 334);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.Name = "AccountDisplay";
            this.Text = "AccountDisplay";
            this.Load += new System.EventHandler(this.AccountDisplay_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fullnamelb;
        private System.Windows.Forms.Label hello;
        private System.Windows.Forms.Button ViewAccountbtn;
        private System.Windows.Forms.Label Emaillb;
        private System.Windows.Forms.Button PersonalInfo;
        private System.Windows.Forms.TextBox Custidtb;
        private System.Windows.Forms.TextBox Nametb;
        private System.Windows.Forms.TextBox Emailtb;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ListView listViewer;
        private System.Windows.Forms.Button Depositbtn;
        private System.Windows.Forms.Button Withdrawlbtn;
        private System.Windows.Forms.Label Addresslb;
        private System.Windows.Forms.Label lastNamelb;
        private System.Windows.Forms.Label Fnamelb;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Passwordlb;
        private System.Windows.Forms.Button upDatebtn;
        private System.Windows.Forms.TextBox textBoxcid;
        private System.Windows.Forms.Label Custidlb;
        private System.Windows.Forms.TextBox textBoxPw;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.Label label1;
    }
}