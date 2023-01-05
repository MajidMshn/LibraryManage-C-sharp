namespace LibraryManagment.Forms
{
    partial class LoanManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btbAddLoan = new System.Windows.Forms.Button();
            this.loanGridView = new System.Windows.Forms.DataGridView();
            this.Return = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.loanGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btbAddLoan
            // 
            this.btbAddLoan.AutoSize = true;
            this.btbAddLoan.BackColor = System.Drawing.Color.BurlyWood;
            this.btbAddLoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btbAddLoan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btbAddLoan.FlatAppearance.BorderSize = 2;
            this.btbAddLoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btbAddLoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btbAddLoan.Location = new System.Drawing.Point(26, 51);
            this.btbAddLoan.Margin = new System.Windows.Forms.Padding(4);
            this.btbAddLoan.Name = "btbAddLoan";
            this.btbAddLoan.Size = new System.Drawing.Size(146, 49);
            this.btbAddLoan.TabIndex = 0;
            this.btbAddLoan.Text = "ثبت امانت";
            this.btbAddLoan.UseVisualStyleBackColor = false;
            this.btbAddLoan.Click += new System.EventHandler(this.btbAddLoan_Click);
            // 
            // loanGridView
            // 
            this.loanGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loanGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loanGridView.ColumnHeadersHeight = 58;
            this.loanGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Return,
            this.Column6,
            this.Column5,
            this.ReturnDate,
            this.BookName,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.id});
            this.loanGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loanGridView.Location = new System.Drawing.Point(0, 164);
            this.loanGridView.Margin = new System.Windows.Forms.Padding(4);
            this.loanGridView.Name = "loanGridView";
            this.loanGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loanGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.loanGridView.RowHeadersWidth = 102;
            this.loanGridView.RowTemplate.Height = 40;
            this.loanGridView.Size = new System.Drawing.Size(968, 348);
            this.loanGridView.TabIndex = 1;
            this.loanGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loanGridView_CellContentClick);
            this.loanGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loanGridView_CellDoubleClick);
            // 
            // Return
            // 
            this.Return.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Return.DefaultCellStyle = dataGridViewCellStyle7;
            this.Return.HeaderText = "عودت";
            this.Return.MinimumWidth = 12;
            this.Return.Name = "Return";
            this.Return.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Return.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Return.Text = "عودت";
            this.Return.ToolTipText = "عودت";
            this.Return.UseColumnTextForButtonValue = true;
            this.Return.Width = 143;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Red;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column6.HeaderText = "حذف ";
            this.Column6.MinimumWidth = 100;
            this.Column6.Name = "Column6";
            this.Column6.Text = "حذف ";
            this.Column6.ToolTipText = "حذف";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.DataPropertyName = "LoanDate";
            this.Column5.HeaderText = "تاریخ امانت";
            this.Column5.MinimumWidth = 12;
            this.Column5.Name = "Column5";
            this.Column5.Width = 210;
            // 
            // ReturnDate
            // 
            this.ReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.HeaderText = "تاریخ بازگشت";
            this.ReturnDate.MinimumWidth = 12;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Width = 240;
            // 
            // BookName
            // 
            this.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "نام کتاب";
            this.BookName.MinimumWidth = 12;
            this.BookName.Name = "BookName";
            this.BookName.Width = 169;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "Shabak";
            this.Column1.HeaderText = "شابک";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.Width = 132;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "نام عضو";
            this.Column2.MinimumWidth = 12;
            this.Column2.Name = "Column2";
            this.Column2.Width = 176;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.DataPropertyName = "Family";
            this.Column3.HeaderText = "نام خانوادگی";
            this.Column3.MinimumWidth = 12;
            this.Column3.Name = "Column3";
            this.Column3.Width = 221;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.DataPropertyName = "NC";
            this.Column4.HeaderText = "کد ملی";
            this.Column4.MinimumWidth = 12;
            this.Column4.Name = "Column4";
            this.Column4.Width = 151;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 12;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // LoanManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 512);
            this.Controls.Add(this.loanGridView);
            this.Controls.Add(this.btbAddLoan);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoanManage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت امانات";
            this.Load += new System.EventHandler(this.LoanManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbAddLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn shabak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member;
        private System.Windows.Forms.DataGridView loanGridView;
        private System.Windows.Forms.DataGridViewButtonColumn Return;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}