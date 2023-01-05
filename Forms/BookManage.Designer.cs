namespace LibraryManagment.Forms
{
    partial class BookManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.comboShelf = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shabak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(930, 60);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(261, 60);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "افزودن کتاب";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // comboShelf
            // 
            this.comboShelf.FormattingEnabled = true;
            this.comboShelf.Location = new System.Drawing.Point(511, 209);
            this.comboShelf.Name = "comboShelf";
            this.comboShelf.Size = new System.Drawing.Size(392, 39);
            this.comboShelf.TabIndex = 1;
            this.comboShelf.SelectedValueChanged += new System.EventHandler(this.comboShelf_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Location = new System.Drawing.Point(72, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 23);
            this.panel1.TabIndex = 2;
            // 
            // bookGridView
            // 
            this.bookGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.bookName,
            this.auther,
            this.publisher,
            this.count,
            this.shabak,
            this.id});
            this.bookGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bookGridView.Location = new System.Drawing.Point(0, 360);
            this.bookGridView.Name = "bookGridView";
            this.bookGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bookGridView.RowHeadersWidth = 102;
            this.bookGridView.RowTemplate.Height = 40;
            this.bookGridView.Size = new System.Drawing.Size(1261, 524);
            this.bookGridView.TabIndex = 3;
            this.bookGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bookGridView_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "حذف";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Text = "حذف";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 115;
            // 
            // bookName
            // 
            this.bookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.bookName.DataPropertyName = "BookName";
            this.bookName.HeaderText = "نام کتاب";
            this.bookName.MinimumWidth = 12;
            this.bookName.Name = "bookName";
            this.bookName.Width = 144;
            // 
            // auther
            // 
            this.auther.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.auther.DataPropertyName = "Auther";
            this.auther.HeaderText = "نویسنده";
            this.auther.MinimumWidth = 12;
            this.auther.Name = "auther";
            this.auther.Width = 137;
            // 
            // publisher
            // 
            this.publisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.publisher.DataPropertyName = "Publisher";
            this.publisher.HeaderText = "ناشر";
            this.publisher.MinimumWidth = 12;
            this.publisher.Name = "publisher";
            this.publisher.Width = 113;
            // 
            // count
            // 
            this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.count.DataPropertyName = "Count";
            this.count.HeaderText = "تعداد";
            this.count.MinimumWidth = 12;
            this.count.Name = "count";
            this.count.Width = 113;
            // 
            // shabak
            // 
            this.shabak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.shabak.DataPropertyName = "Shabak";
            this.shabak.HeaderText = "شابک";
            this.shabak.MinimumWidth = 12;
            this.shabak.Name = "shabak";
            this.shabak.Width = 116;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 12;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 250;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(106, 199);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(292, 49);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(938, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "انتخاب دسته بندی";
            // 
            // BookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 884);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.bookGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboShelf);
            this.Controls.Add(this.btnAddBook);
            this.Name = "BookManage";
            this.Text = "مدیریت کتب";
            this.Load += new System.EventHandler(this.BookManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ComboBox comboShelf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView bookGridView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn auther;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn shabak;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}