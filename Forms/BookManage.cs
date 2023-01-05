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
    public partial class BookManage : Form
    {
        public BookManage()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            NewBook nb = new NewBook();
            
            nb.Show();
        }

            DAL DB = new DAL();
        private void BookManage_Load(object sender, EventArgs e)
        {
            DB.bookGridShow(this.bookGridView);
            DB.ShelfLists(comboShelf);
        }

        private void comboShelf_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int cc = int.Parse(comboShelf.SelectedValue.ToString());
            try
            {
                DB.bookGridShowFilter(bookGridView, cc);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }

        private void bookGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0 )
            {
                try
                {
                    int id = int.Parse(bookGridView.CurrentRow.Cells["id"].Value.ToString());
                    DB.deleteBook(id);
                }
                catch (Exception ex )
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
