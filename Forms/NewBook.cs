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
    public partial class NewBook : Form
    {
        public NewBook()
        {
            InitializeComponent();
        }
        BLL bl = new BLL();
        private void NewBook_Load(object sender, EventArgs e)
        {
            DAL DB = new DAL();
            DB.ShelfLists(comboShelfs);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            Control[] txts =
            {
                txtBookName, txtAuther, txtPublisher, txtShabak, txtCount
            };
            string shelfId =comboShelfs.SelectedValue.ToString();
            try
            {               

                bl.ValidateItems(txts,shelfId);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void comboShelfs_ValueMemberChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboShelfs.ValueMember);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            BookManage bm = new BookManage();
            bm.Show();
        }

   
    }
}
