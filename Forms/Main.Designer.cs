namespace LibraryManagment.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnShelfs = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnLoans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShelfs
            // 
            this.btnShelfs.AutoSize = true;
            this.btnShelfs.BackColor = System.Drawing.Color.Tan;
            this.btnShelfs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShelfs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShelfs.FlatAppearance.BorderSize = 3;
            this.btnShelfs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShelfs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShelfs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShelfs.Location = new System.Drawing.Point(174, 371);
            this.btnShelfs.MinimumSize = new System.Drawing.Size(150, 0);
            this.btnShelfs.Name = "btnShelfs";
            this.btnShelfs.Size = new System.Drawing.Size(313, 74);
            this.btnShelfs.TabIndex = 0;
            this.btnShelfs.Text = "مدیریت قفسه ها";
            this.btnShelfs.UseVisualStyleBackColor = false;
            this.btnShelfs.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.AutoSize = true;
            this.btnBooks.BackColor = System.Drawing.Color.Tan;
            this.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBooks.FlatAppearance.BorderSize = 3;
            this.btnBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBooks.Location = new System.Drawing.Point(279, 243);
            this.btnBooks.MinimumSize = new System.Drawing.Size(150, 0);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(300, 74);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.Text = "مدیریت کتاب ها";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.AutoSize = true;
            this.btnUsers.BackColor = System.Drawing.Color.Tan;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsers.FlatAppearance.BorderSize = 3;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUsers.Location = new System.Drawing.Point(112, 499);
            this.btnUsers.MinimumSize = new System.Drawing.Size(150, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(283, 74);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "مدیریت اعضا";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnLoans
            // 
            this.btnLoans.AutoSize = true;
            this.btnLoans.BackColor = System.Drawing.Color.Tan;
            this.btnLoans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoans.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoans.FlatAppearance.BorderSize = 3;
            this.btnLoans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoans.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoans.Location = new System.Drawing.Point(43, 627);
            this.btnLoans.MinimumSize = new System.Drawing.Size(150, 0);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Size = new System.Drawing.Size(295, 74);
            this.btnLoans.TabIndex = 3;
            this.btnLoans.Text = "مدیریت امانات";
            this.btnLoans.UseVisualStyleBackColor = false;
            this.btnLoans.Click += new System.EventHandler(this.btnLoans_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 892);
            this.Controls.Add(this.btnLoans);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnShelfs);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Main";
            this.Text = "صفحه اصلی";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShelfs;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnLoans;
    }
}