namespace Assignment
{
    partial class editStudentCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxStudentNumber = new System.Windows.Forms.TextBox();
            this.textBoxIssueD = new System.Windows.Forms.TextBox();
            this.textBoxIssueM = new System.Windows.Forms.TextBox();
            this.textBoxIssueY = new System.Windows.Forms.TextBox();
            this.textBoxExpireDate = new System.Windows.Forms.TextBox();
            this.textBoxPNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IssueDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expire Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Library Number:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(153, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(223, 20);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxStudentNumber
            // 
            this.textBoxStudentNumber.Location = new System.Drawing.Point(153, 83);
            this.textBoxStudentNumber.Name = "textBoxStudentNumber";
            this.textBoxStudentNumber.Size = new System.Drawing.Size(223, 20);
            this.textBoxStudentNumber.TabIndex = 6;
            this.textBoxStudentNumber.TextChanged += new System.EventHandler(this.textBoxStudentNumber_TextChanged);
            // 
            // textBoxIssueD
            // 
            this.textBoxIssueD.Location = new System.Drawing.Point(153, 123);
            this.textBoxIssueD.Name = "textBoxIssueD";
            this.textBoxIssueD.Size = new System.Drawing.Size(45, 20);
            this.textBoxIssueD.TabIndex = 7;
            this.textBoxIssueD.TextChanged += new System.EventHandler(this.textBoxIssueD_TextChanged);
            // 
            // textBoxIssueM
            // 
            this.textBoxIssueM.Location = new System.Drawing.Point(231, 123);
            this.textBoxIssueM.Name = "textBoxIssueM";
            this.textBoxIssueM.Size = new System.Drawing.Size(57, 20);
            this.textBoxIssueM.TabIndex = 8;
            this.textBoxIssueM.TextChanged += new System.EventHandler(this.textBoxIssueM_TextChanged);
            // 
            // textBoxIssueY
            // 
            this.textBoxIssueY.Location = new System.Drawing.Point(317, 123);
            this.textBoxIssueY.Name = "textBoxIssueY";
            this.textBoxIssueY.Size = new System.Drawing.Size(59, 20);
            this.textBoxIssueY.TabIndex = 9;
            this.textBoxIssueY.TextChanged += new System.EventHandler(this.textBoxIssueY_TextChanged);
            // 
            // textBoxExpireDate
            // 
            this.textBoxExpireDate.Location = new System.Drawing.Point(153, 168);
            this.textBoxExpireDate.Name = "textBoxExpireDate";
            this.textBoxExpireDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxExpireDate.TabIndex = 10;
            this.textBoxExpireDate.TextChanged += new System.EventHandler(this.textBoxExpireDate_TextChanged);
            // 
            // textBoxPNumber
            // 
            this.textBoxPNumber.Location = new System.Drawing.Point(153, 216);
            this.textBoxPNumber.Name = "textBoxPNumber";
            this.textBoxPNumber.Size = new System.Drawing.Size(223, 20);
            this.textBoxPNumber.TabIndex = 11;
            this.textBoxPNumber.TextChanged += new System.EventHandler(this.textBoxPNumber_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "/";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // editStudentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 321);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPNumber);
            this.Controls.Add(this.textBoxExpireDate);
            this.Controls.Add(this.textBoxIssueY);
            this.Controls.Add(this.textBoxIssueM);
            this.Controls.Add(this.textBoxIssueD);
            this.Controls.Add(this.textBoxStudentNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editStudentCard";
            this.Text = "editStudentCard";
            this.Load += new System.EventHandler(this.editStudentCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxStudentNumber;
        private System.Windows.Forms.TextBox textBoxIssueD;
        private System.Windows.Forms.TextBox textBoxIssueM;
        private System.Windows.Forms.TextBox textBoxIssueY;
        private System.Windows.Forms.TextBox textBoxExpireDate;
        private System.Windows.Forms.TextBox textBoxPNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}