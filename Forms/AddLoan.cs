using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagment.modules;
using LibraryManagment.Classes;


namespace LibraryManagment.Forms
{
    public partial class AddLoan : Form
    {
        public AddLoan()
        {
            InitializeComponent();
        }
        libraryDBEntities ctx = new libraryDBEntities();
        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNC.Text) && !string.IsNullOrWhiteSpace(txtShabak.Text))
            {
                try
                {
                    BLL bl = new BLL();
                    bl.AddLoan(new ObjItems { MemberNc = txtNC.Text, BookShabak = txtShabak.Text });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"خطای برنامه");
                }
            }
            else
            {
                MessageBox.Show("پرکردن فیلدها الزامیست","خطای ورودی ");
            }

            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            LoanManage lm = new LoanManage();
            lm.Show();
        }
    }
}
