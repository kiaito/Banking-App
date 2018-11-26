namespace BankAcc
{
    partial class admindisplay
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ViewAllAcc = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Createbtn = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewAcc = new System.Windows.Forms.ListView();
            this.groupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.groupBox3);
            this.groupBox.Controls.Add(this.groupBox1);
            this.groupBox.Location = new System.Drawing.Point(8, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(543, 129);
            this.groupBox.TabIndex = 10;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Admin Panel";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ViewAllAcc);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Location = new System.Drawing.Point(283, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 102);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Controls";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // ViewAllAcc
            // 
            this.ViewAllAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllAcc.Location = new System.Drawing.Point(6, 19);
            this.ViewAllAcc.Name = "ViewAllAcc";
            this.ViewAllAcc.Size = new System.Drawing.Size(105, 76);
            this.ViewAllAcc.TabIndex = 11;
            this.ViewAllAcc.Text = "View All Accounts";
            this.ViewAllAcc.UseVisualStyleBackColor = true;
            this.ViewAllAcc.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(117, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 34);
            this.button5.TabIndex = 2;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(117, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 34);
            this.button6.TabIndex = 4;
            this.button6.Text = "Create";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Deletebtn);
            this.groupBox1.Controls.Add(this.Createbtn);
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 102);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Controls";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 76);
            this.button2.TabIndex = 11;
            this.button2.Text = "View All Customers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(117, 61);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(107, 34);
            this.Deletebtn.TabIndex = 2;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // Createbtn
            // 
            this.Createbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createbtn.Location = new System.Drawing.Point(117, 19);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(107, 34);
            this.Createbtn.TabIndex = 4;
            this.Createbtn.Text = "Create";
            this.Createbtn.UseVisualStyleBackColor = true;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(18, 19);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(509, 155);
            this.listView.TabIndex = 11;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewAcc);
            this.groupBox2.Controls.Add(this.listView);
            this.groupBox2.Location = new System.Drawing.Point(8, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 192);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // listViewAcc
            // 
            this.listViewAcc.Location = new System.Drawing.Point(18, 27);
            this.listViewAcc.Name = "listViewAcc";
            this.listViewAcc.Size = new System.Drawing.Size(509, 147);
            this.listViewAcc.TabIndex = 12;
            this.listViewAcc.UseCompatibleStateImageBehavior = false;
            // 
            // admindisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox);
            this.Name = "admindisplay";
            this.Text = "admindisplay";
            this.groupBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ViewAllAcc;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewAcc;
    }
}