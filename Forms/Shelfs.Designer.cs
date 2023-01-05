namespace LibraryManagment.Forms
{
    partial class Shelfs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shelfs));
            this.shelfDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.shelfId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نام = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddShelf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shelfDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // shelfDataGrid
            // 
            this.shelfDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.shelfDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shelfDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shelfDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.shelfId,
            this.نام});
            this.shelfDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shelfDataGrid.Location = new System.Drawing.Point(0, 432);
            this.shelfDataGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shelfDataGrid.Name = "shelfDataGrid";
            this.shelfDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.shelfDataGrid.RowHeadersWidth = 102;
            this.shelfDataGrid.RowTemplate.Height = 40;
            this.shelfDataGrid.Size = new System.Drawing.Size(857, 435);
            this.shelfDataGrid.TabIndex = 0;
            this.shelfDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shelfDataGrid_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "حذف";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.Text = "حذف";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 70;
            // 
            // shelfId
            // 
            this.shelfId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.shelfId.DataPropertyName = "shelfId";
            this.shelfId.HeaderText = "آیدی";
            this.shelfId.MinimumWidth = 120;
            this.shelfId.Name = "shelfId";
            this.shelfId.Width = 120;
            // 
            // نام
            // 
            this.نام.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.نام.DataPropertyName = "shelfName";
            this.نام.HeaderText = "نام";
            this.نام.MinimumWidth = 120;
            this.نام.Name = "نام";
            this.نام.Width = 120;
            // 
            // btnAddShelf
            // 
            this.btnAddShelf.BackColor = System.Drawing.Color.Peru;
            this.btnAddShelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShelf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddShelf.Location = new System.Drawing.Point(623, 369);
            this.btnAddShelf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddShelf.Name = "btnAddShelf";
            this.btnAddShelf.Size = new System.Drawing.Size(183, 48);
            this.btnAddShelf.TabIndex = 1;
            this.btnAddShelf.Text = "قفسه جدید";
            this.btnAddShelf.UseVisualStyleBackColor = false;
            this.btnAddShelf.Click += new System.EventHandler(this.btnAddShelf_Click);
            // 
            // Shelfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 867);
            this.Controls.Add(this.btnAddShelf);
            this.Controls.Add(this.shelfDataGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Shelfs";
            this.Text = "مدیریت قفسه ها";
            this.Load += new System.EventHandler(this.Shelfs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shelfDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView shelfDataGrid;
        private System.Windows.Forms.Button btnAddShelf;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfId;
        private System.Windows.Forms.DataGridViewTextBoxColumn نام;
    }
}