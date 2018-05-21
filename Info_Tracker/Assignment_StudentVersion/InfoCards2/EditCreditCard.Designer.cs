namespace Assignment
{
    partial class EditCreditCard
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
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxStartM = new System.Windows.Forms.TextBox();
            this.textBoxStartY = new System.Windows.Forms.TextBox();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.textBoxExpireM = new System.Windows.Forms.TextBox();
            this.textBoxExpireY = new System.Windows.Forms.TextBox();
            this.textBoxNameOnCard = new System.Windows.Forms.TextBox();
            this.textBoxCVC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Card Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expire Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name On Card:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CVC:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(123, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(160, 20);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxStartM
            // 
            this.textBoxStartM.Location = new System.Drawing.Point(123, 95);
            this.textBoxStartM.Name = "textBoxStartM";
            this.textBoxStartM.Size = new System.Drawing.Size(25, 20);
            this.textBoxStartM.TabIndex = 7;
            this.textBoxStartM.TextChanged += new System.EventHandler(this.textBoxStartM_TextChanged);
            // 
            // textBoxStartY
            // 
            this.textBoxStartY.Location = new System.Drawing.Point(172, 95);
            this.textBoxStartY.Name = "textBoxStartY";
            this.textBoxStartY.Size = new System.Drawing.Size(48, 20);
            this.textBoxStartY.TabIndex = 8;
            this.textBoxStartY.TextChanged += new System.EventHandler(this.textBoxStartY_TextChanged);
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Location = new System.Drawing.Point(123, 61);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(160, 20);
            this.textBoxCardNumber.TabIndex = 9;
            this.textBoxCardNumber.TextChanged += new System.EventHandler(this.textBoxCardNumber_TextChanged);
            // 
            // textBoxExpireM
            // 
            this.textBoxExpireM.Location = new System.Drawing.Point(123, 132);
            this.textBoxExpireM.Name = "textBoxExpireM";
            this.textBoxExpireM.Size = new System.Drawing.Size(25, 20);
            this.textBoxExpireM.TabIndex = 10;
            this.textBoxExpireM.TextChanged += new System.EventHandler(this.textBoxExpireM_TextChanged);
            // 
            // textBoxExpireY
            // 
            this.textBoxExpireY.Location = new System.Drawing.Point(172, 132);
            this.textBoxExpireY.Name = "textBoxExpireY";
            this.textBoxExpireY.Size = new System.Drawing.Size(48, 20);
            this.textBoxExpireY.TabIndex = 11;
            this.textBoxExpireY.TextChanged += new System.EventHandler(this.textBoxExpireY_TextChanged);
            // 
            // textBoxNameOnCard
            // 
            this.textBoxNameOnCard.Location = new System.Drawing.Point(123, 164);
            this.textBoxNameOnCard.Name = "textBoxNameOnCard";
            this.textBoxNameOnCard.Size = new System.Drawing.Size(160, 20);
            this.textBoxNameOnCard.TabIndex = 12;
            this.textBoxNameOnCard.TextChanged += new System.EventHandler(this.textBoxNameOnCard_TextChanged);
            // 
            // textBoxCVC
            // 
            this.textBoxCVC.Location = new System.Drawing.Point(123, 200);
            this.textBoxCVC.Name = "textBoxCVC";
            this.textBoxCVC.Size = new System.Drawing.Size(59, 20);
            this.textBoxCVC.TabIndex = 13;
            this.textBoxCVC.TextChanged += new System.EventHandler(this.textBoxCVC_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "/";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 309);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCVC);
            this.Controls.Add(this.textBoxNameOnCard);
            this.Controls.Add(this.textBoxExpireY);
            this.Controls.Add(this.textBoxExpireM);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.textBoxStartY);
            this.Controls.Add(this.textBoxStartM);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditCreditCard";
            this.Text = "EditCreditCard";
            this.Load += new System.EventHandler(this.EditCreditCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxStartM;
        private System.Windows.Forms.TextBox textBoxStartY;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.TextBox textBoxExpireM;
        private System.Windows.Forms.TextBox textBoxExpireY;
        private System.Windows.Forms.TextBox textBoxNameOnCard;
        private System.Windows.Forms.TextBox textBoxCVC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}