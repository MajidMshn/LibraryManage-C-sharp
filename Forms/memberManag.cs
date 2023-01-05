using LibraryManagment.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagment.Forms
{
    public partial class memberManag : Form
    {
        public memberManag()
        {
            InitializeComponent();
        }

        private void addMember_Click(object sender, EventArgs e)
        {
            AddMember ad = new AddMember();
            ad.Show();

        }

                DAL DB = new DAL();
        private void memberManag_Load(object sender, EventArgs e)
        {
            try
            {
                DB.MemberList(memberGridView);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"خطای دیتابیس");
            }
        }

        private void memberGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                try
                {
                    int id = int.Parse(memberGridView.CurrentRow.Cells["id"].Value.ToString());
                    DB.deleteMember(id);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
