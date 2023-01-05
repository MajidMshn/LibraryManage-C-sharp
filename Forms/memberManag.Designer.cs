namespace LibraryManagment.Forms
{
    partial class memberManag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memberManag));
            this.addMember = new System.Windows.Forms.Button();
            this.memberGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moblie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.memberGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addMember
            // 
            this.addMember.Location = new System.Drawing.Point(962, 60);
            this.addMember.Name = "addMember";
            this.addMember.Size = new System.Drawing.Size(224, 74);
            this.addMember.TabIndex = 0;
            this.addMember.Text = "ثبت نام ";
            this.addMember.UseVisualStyleBackColor = true;
            this.addMember.Click += new System.EventHandler(this.addMember_Click);
            // 
            // memberGridView
            // 
            this.memberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.name,
            this.Column1,
            this.family,
            this.moblie,
            this.nc,
            this.email,
            this.userName,
            this.roll});
            this.memberGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.memberGridView.Location = new System.Drawing.Point(0, 391);
            this.memberGridView.Name = "memberGridView";
            this.memberGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.memberGridView.RowHeadersWidth = 102;
            this.memberGridView.RowTemplate.Height = 40;
            this.memberGridView.Size = new System.Drawing.Size(1214, 442);
            this.memberGridView.TabIndex = 1;
            this.memberGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberGridView_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "حذف";
            this.Column2.MinimumWidth = 12;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Text = "حذف";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 115;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "نام";
            this.name.MinimumWidth = 12;
            this.name.Name = "name";
            this.name.Width = 92;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 250;
            // 
            // family
            // 
            this.family.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.family.DataPropertyName = "Family";
            this.family.HeaderText = "نام خانوادگی";
            this.family.MinimumWidth = 12;
            this.family.Name = "family";
            this.family.Width = 185;
            // 
            // moblie
            // 
            this.moblie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.moblie.DataPropertyName = "Mobile";
            this.moblie.HeaderText = "موبایل";
            this.moblie.MinimumWidth = 12;
            this.moblie.Name = "moblie";
            this.moblie.Width = 126;
            // 
            // nc
            // 
            this.nc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nc.DataPropertyName = "NC";
            this.nc.HeaderText = "کدملی";
            this.nc.MinimumWidth = 12;
            this.nc.Name = "nc";
            this.nc.Width = 123;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "ایمیل";
            this.email.MinimumWidth = 12;
            this.email.Name = "email";
            this.email.Width = 114;
            // 
            // userName
            // 
            this.userName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.userName.DataPropertyName = "UserName";
            this.userName.HeaderText = "نام کاربری";
            this.userName.MinimumWidth = 12;
            this.userName.Name = "userName";
            this.userName.Width = 170;
            // 
            // roll
            // 
            this.roll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.roll.DataPropertyName = "RollName";
            this.roll.HeaderText = "نقش";
            this.roll.MinimumWidth = 12;
            this.roll.Name = "roll";
            this.roll.Width = 106;
            // 
            // memberManag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 833);
            this.Controls.Add(this.memberGridView);
            this.Controls.Add(this.addMember);
            this.Name = "memberManag";
            this.Text = "مدیریت اعضا";
            this.Load += new System.EventHandler(this.memberManag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addMember;
        private System.Windows.Forms.DataGridView memberGridView;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn moblie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nc;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn roll;
    }
}