namespace LibraryManagment.Forms
{
    partial class AddLoan
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
            this.txtNC = new System.Windows.Forms.TextBox();
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.txtShabak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(871, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد ملی عضو";
            // 
            // txtNC
            // 
            this.txtNC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtNC.Location = new System.Drawing.Point(498, 77);
            this.txtNC.Name = "txtNC";
            this.txtNC.Size = new System.Drawing.Size(293, 38);
            this.txtNC.TabIndex = 1;
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.Location = new System.Drawing.Point(66, 77);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(370, 73);
            this.btnAddLoan.TabIndex = 2;
            this.btnAddLoan.Text = "ثبت و ذخیره";
            this.btnAddLoan.UseVisualStyleBackColor = true;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // txtShabak
            // 
            this.txtShabak.Location = new System.Drawing.Point(494, 201);
            this.txtShabak.Name = "txtShabak";
            this.txtShabak.Size = new System.Drawing.Size(293, 38);
            this.txtShabak.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(871, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "شابک کتاب";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(66, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(370, 73);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 512);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtShabak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddLoan);
            this.Controls.Add(this.txtNC);
            this.Controls.Add(this.label1);
            this.Name = "AddLoan";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ثبت امانت";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNC;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.TextBox txtShabak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
    }
}