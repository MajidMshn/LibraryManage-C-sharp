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
    public partial class NewShelf : Form
    {
        public NewShelf()
        {
            InitializeComponent();
        }
        
        
      
        private void btnAddNewShelf_Click(object sender, EventArgs e)
        {           
            
            if(!string.IsNullOrWhiteSpace(txtNewShelf.Text))
            {
                try
                {
                    BLL bl = new BLL();
                    bl.validateInp(new ObjItems { ShelfName = txtNewShelf.Text });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("لطفا مقادیر خواسته شده را وارد کنید");
                
            }
        }      
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            Shelfs s = new Shelfs();
            s.Show();
        }
    }
}
