﻿namespace LibraryManagment.Forms
{
    partial class AddBook
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboShelfs = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShabak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuther = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(698, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 32);
            this.label6.TabIndex = 27;
            this.label6.Text = "نام قفسه";
            // 
            // comboShelfs
            // 
            this.comboShelfs.FormattingEnabled = true;
            this.comboShelfs.Location = new System.Drawing.Point(254, 462);
            this.comboShelfs.Name = "comboShelfs";
            this.comboShelfs.Size = new System.Drawing.Size(346, 39);
            this.comboShelfs.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(966, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "ناشر";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(652, 304);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(277, 38);
            this.txtPublisher.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "تعداد";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(116, 216);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(277, 38);
            this.txtCount.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "شابک";
            // 
            // txtShabak
            // 
            this.txtShabak.Location = new System.Drawing.Point(116, 111);
            this.txtShabak.Name = "txtShabak";
            this.txtShabak.Size = new System.Drawing.Size(277, 38);
            this.txtShabak.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(966, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "نویسنده";
            // 
            // txtAuther
            // 
            this.txtAuther.Location = new System.Drawing.Point(652, 216);
            this.txtAuther.Name = "txtAuther";
            this.txtAuther.Size = new System.Drawing.Size(277, 38);
            this.txtAuther.TabIndex = 18;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(568, 663);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(276, 60);
            this.btnAddBook.TabIndex = 17;
            this.btnAddBook.Text = "ثبت";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(211, 663);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(276, 60);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(966, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "نام کتاب";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(652, 131);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(277, 38);
            this.txtBookName.TabIndex = 14;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 835);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboShelfs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShabak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAuther);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookName);
            this.Name = "AddBook";
            this.Text = "ثبت کتاب";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboShelfs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShabak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAuther;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookName;
    }
}