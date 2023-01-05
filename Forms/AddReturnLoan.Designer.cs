namespace LibraryManagment.Forms
{
    partial class AddReturnLoan
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
            this.txtShabak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.txtNC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtShabak
            // 
            this.txtShabak.Location = new System.Drawing.Point(265, 192);
            this.txtShabak.Name = "txtShabak";
            this.txtShabak.Size = new System.Drawing.Size(293, 38);
            this.txtShabak.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "شابک کتاب";
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.AutoSize = true;
            this.btnAddLoan.FlatAppearance.BorderSize = 3;
            this.btnAddLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddLoan.Location = new System.Drawing.Point(697, 88);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(370, 142);
            this.btnAddLoan.TabIndex = 7;
            this.btnAddLoan.Text = "ثبت و ذخیره";
            this.btnAddLoan.UseVisualStyleBackColor = true;
            // 
            // txtNC
            // 
            this.txtNC.Location = new System.Drawing.Point(265, 88);
            this.txtNC.Name = "txtNC";
            this.txtNC.Size = new System.Drawing.Size(293, 38);
            this.txtNC.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "کد ملی عضو";
            // 
            // AddReturnLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 475);
            this.Controls.Add(this.txtShabak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddLoan);
            this.Controls.Add(this.txtNC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddReturnLoan";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ثبت بازگشت کتاب";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShabak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.TextBox txtNC;
        private System.Windows.Forms.Label label1;
    }
}