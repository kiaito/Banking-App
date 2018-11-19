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
            this.SuspendLayout();
            // 
            // Sumitbtn
            // 
            this.Sumitbtn.Location = new System.Drawing.Point(280, 144);
            this.Sumitbtn.Name = "Sumitbtn";
            this.Sumitbtn.Size = new System.Drawing.Size(75, 23);
            this.Sumitbtn.TabIndex = 0;
            this.Sumitbtn.Text = "Submit";
            this.Sumitbtn.UseVisualStyleBackColor = true;
            // 
            // UserNamelb
            // 
            this.UserNamelb.AutoSize = true;
            this.UserNamelb.Location = new System.Drawing.Point(188, 86);
            this.UserNamelb.Name = "UserNamelb";
            this.UserNamelb.Size = new System.Drawing.Size(60, 13);
            this.UserNamelb.TabIndex = 1;
            this.UserNamelb.Text = "User Name";
            // 
            // Passwordlb
            // 
            this.Passwordlb.AutoSize = true;
            this.Passwordlb.Location = new System.Drawing.Point(188, 115);
            this.Passwordlb.Name = "Passwordlb";
            this.Passwordlb.Size = new System.Drawing.Size(53, 13);
            this.Passwordlb.TabIndex = 2;
            this.Passwordlb.Text = "Password";
            // 
            // Passwordtb
            // 
            this.Passwordtb.Location = new System.Drawing.Point(255, 108);
            this.Passwordtb.Name = "Passwordtb";
            this.Passwordtb.Size = new System.Drawing.Size(100, 20);
            this.Passwordtb.TabIndex = 3;
            // 
            // UserNametb
            // 
            this.UserNametb.Location = new System.Drawing.Point(255, 79);
            this.UserNametb.Name = "UserNametb";
            this.UserNametb.Size = new System.Drawing.Size(100, 20);
            this.UserNametb.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
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
    }
}