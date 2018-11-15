namespace BankAcc
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
            this.Customerbtn = new System.Windows.Forms.Button();
            this.Accountbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customerbtn
            // 
            this.Customerbtn.Location = new System.Drawing.Point(0, 0);
            this.Customerbtn.Name = "Customerbtn";
            this.Customerbtn.Size = new System.Drawing.Size(75, 23);
            this.Customerbtn.TabIndex = 0;
            this.Customerbtn.Text = "Customer";
            this.Customerbtn.UseVisualStyleBackColor = true;
            this.Customerbtn.Click += new System.EventHandler(this.Customerbtn_Click);
            // 
            // Accountbtn
            // 
            this.Accountbtn.Location = new System.Drawing.Point(158, 87);
            this.Accountbtn.Name = "Accountbtn";
            this.Accountbtn.Size = new System.Drawing.Size(75, 23);
            this.Accountbtn.TabIndex = 1;
            this.Accountbtn.Text = "account";
            this.Accountbtn.UseVisualStyleBackColor = true;
            this.Accountbtn.Click += new System.EventHandler(this.Accountbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Accountbtn);
            this.Controls.Add(this.Customerbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Customerbtn;
        private System.Windows.Forms.Button Accountbtn;
    }
}

