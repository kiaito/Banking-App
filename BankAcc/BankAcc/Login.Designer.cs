namespace BankAcc
{
    partial class Login
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
            this.Sumitbtn = new System.Windows.Forms.Button();
            this.UserNamelb = new System.Windows.Forms.Label();
            this.Passwordlb = new System.Windows.Forms.Label();
            this.Passwordtb = new System.Windows.Forms.TextBox();
            this.UserNametb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sumitbtn
            // 
            this.Sumitbtn.Location = new System.Drawing.Point(258, 181);
            this.Sumitbtn.Name = "Sumitbtn";
            this.Sumitbtn.Size = new System.Drawing.Size(75, 23);
            this.Sumitbtn.TabIndex = 3;
            this.Sumitbtn.Text = "Submit";
            this.Sumitbtn.UseVisualStyleBackColor = true;
            this.Sumitbtn.Click += new System.EventHandler(this.Sumitbtn_Click);
            // 
            // UserNamelb
            // 
            this.UserNamelb.AutoSize = true;
            this.UserNamelb.Location = new System.Drawing.Point(166, 123);
            this.UserNamelb.Name = "UserNamelb";
            this.UserNamelb.Size = new System.Drawing.Size(60, 13);
            this.UserNamelb.TabIndex = 1;
            this.UserNamelb.Text = "User Name";
            // 
            // Passwordlb
            // 
            this.Passwordlb.AutoSize = true;
            this.Passwordlb.Location = new System.Drawing.Point(166, 152);
            this.Passwordlb.Name = "Passwordlb";
            this.Passwordlb.Size = new System.Drawing.Size(53, 13);
            this.Passwordlb.TabIndex = 2;
            this.Passwordlb.Text = "Password";
            // 
            // Passwordtb
            // 
            this.Passwordtb.Location = new System.Drawing.Point(233, 145);
            this.Passwordtb.Name = "Passwordtb";
            this.Passwordtb.Size = new System.Drawing.Size(100, 20);
            this.Passwordtb.TabIndex = 2;
            // 
            // UserNametb
            // 
            this.UserNametb.Location = new System.Drawing.Point(233, 116);
            this.UserNametb.Name = "UserNametb";
            this.UserNametb.Size = new System.Drawing.Size(100, 20);
            this.UserNametb.TabIndex = 1;
            this.UserNametb.TextChanged += new System.EventHandler(this.UserNametb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to A-1 Banking Portal";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNametb);
            this.Controls.Add(this.Passwordtb);
            this.Controls.Add(this.Passwordlb);
            this.Controls.Add(this.UserNamelb);
            this.Controls.Add(this.Sumitbtn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sumitbtn;
        private System.Windows.Forms.Label UserNamelb;
        private System.Windows.Forms.Label Passwordlb;
        private System.Windows.Forms.TextBox Passwordtb;
        private System.Windows.Forms.TextBox UserNametb;
        private System.Windows.Forms.Label label1;
    }
}