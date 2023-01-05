using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagment.Classes;
using LibraryManagment.modules;

namespace LibraryManagment.Forms
{
    public partial class Shelfs : Form
    {
        public Shelfs()
        {
            InitializeComponent();
        }

        private void btnAddShelf_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            NewShelf newShelf = new NewShelf();
            newShelf.Show();
           
        }
        libraryDBEntities ctx = new libraryDBEntities();
        private void Shelfs_Load(object sender, EventArgs e)
        {
            shelfDataGrid.DataSource = ctx.Shelves.Select(p => new { p.ShelfId, p.ShelfName }).ToList();
        }

        private void shelfDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                try
                {
                    int id = int.Parse(shelfDataGrid.CurrentRow.Cells["shelfId"].Value.ToString());
                    DAL DB = new DAL();
                    DB.deleteShelf(id);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
