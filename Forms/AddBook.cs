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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }
        BLL bl = new BLL();
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            TextBox[] txts =
            {
                txtBookName, txtAuther, txtCount, txtPublisher, txtShabak
            };
            try
            {


                //bl.validateItems(txts, new ObjItems
                //{
                //    BookName = txtBookName.Text,
                //    BookAuther = txtAuther.Text,
                //    BookPublisher = txtPublisher.Text,
                //    BookCount = int.Parse(txtCount.Text),
                //    BookShabak = int.Parse(txtShabak.Text),
                //    BookShlefId = comboShelfs.SelectedValue.ToString()

                //});
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
