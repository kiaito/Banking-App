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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullnamelb
            // 
            this.fullnamelb.AutoSize = true;
            this.fullnamelb.Location = new System.Drawing.Point(156, 148);
            this.fullnamelb.Name = "fullnamelb";
            this.fullnamelb.Size = new System.Drawing.Size(49, 13);
            this.fullnamelb.TabIndex = 0;
            this.fullnamelb.Text = "Fullname";
            // 
            // hello
            // 
            this.hello.AutoSize = true;
            this.hello.Location = new System.Drawing.Point(84, 148);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(31, 13);
            this.hello.TabIndex = 1;
            this.hello.Text = "Hello";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "View Accounts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hello);
            this.Controls.Add(this.fullnamelb);
            this.Name = "AccountDisplay";
            this.Text = "AccountDisplay";
            this.Load += new System.EventHandler(this.AccountDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullnamelb;
        private System.Windows.Forms.Label hello;
        private System.Windows.Forms.Button button1;
    }
}