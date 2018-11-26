namespace BankAcc
{
    partial class Withdrawl
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
            this.EnterBtn = new System.Windows.Forms.Button();
            this.textboxAcc = new System.Windows.Forms.TextBox();
            this.textBoxAm = new System.Windows.Forms.TextBox();
            this.Account = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EnterBtn);
            this.groupBox1.Controls.Add(this.textboxAcc);
            this.groupBox1.Controls.Add(this.textBoxAm);
            this.groupBox1.Controls.Add(this.Account);
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 147);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WithDrawl Details";
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(90, 109);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(75, 23);
            this.EnterBtn.TabIndex = 5;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // textboxAcc
            // 
            this.textboxAcc.Location = new System.Drawing.Point(65, 33);
            this.textboxAcc.Name = "textboxAcc";
            this.textboxAcc.Size = new System.Drawing.Size(100, 20);
            this.textboxAcc.TabIndex = 2;
            this.textboxAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAm
            // 
            this.textBoxAm.Location = new System.Drawing.Point(65, 67);
            this.textBoxAm.Name = "textBoxAm";
            this.textBoxAm.Size = new System.Drawing.Size(100, 20);
            this.textBoxAm.TabIndex = 3;
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Location = new System.Drawing.Point(8, 36);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(51, 13);
            this.Account.TabIndex = 0;
            this.Account.Text = "Accout #";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(8, 70);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 1;
            this.Amount.Text = "Amount";
            // 
            // Withdrawl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 174);
            this.Controls.Add(this.groupBox1);
            this.Name = "Withdrawl";
            this.Text = "Withdrawl";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.TextBox textboxAcc;
        private System.Windows.Forms.TextBox textBoxAm;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label Amount;
    }
}