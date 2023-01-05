
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
using Library_Manag.modules;

namespace LibraryManagment.Forms
{
    public partial class LoanManage : Form
    {
        public LoanManage()
        {
            InitializeComponent();
        }
        libraryDBEntities ctx = new libraryDBEntities();
        DAL DB = new DAL();
        private void btbAddLoan_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            AddLoan addLoan = new AddLoan();
            addLoan.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            AddReturnLoan arl = new AddReturnLoan();
            arl.Show();
        }

        private void LoanManage_Load(object sender, EventArgs e)
        {
            var loans = ctx.Loans.Select(p => new
            {
                p.Book.BookName,

                p.Member.Name,
                p.Member.Family,
                p.Member.NC,
                p.LoanDate,
                p.id,
                p.Book.Shabak,
                p.ReturnDate
            }).ToList();

            loanGridView.DataSource = loans;

        }



        private void loanGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ObjItems obj = new ObjItems();
                try
                {
                    int loanId = int.Parse(loanGridView.CurrentRow.Cells["id"].Value.ToString());
                    Loan lo = ctx.Loans.Find(loanId);
                    if (lo.ReturnDate == null)
                    {
                        lo.ReturnDate = obj.persianDate();
                        Book bo = ctx.Books.Where(p => p.Shabak == lo.Book.Shabak).FirstOrDefault();
                        bo.Count++;
                        ctx.SaveChanges();
                        MessageBox.Show("بازگشت کتاب با موفقیت ثبت گردید");
                        ActiveForm.Refresh();
                    }
                    else
                    {
                        throw new Exception("بازگشت کتاب قبلا ثبت شده است ");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
           
        }

        private void loanGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    int id = int.Parse(loanGridView.CurrentRow.Cells["id"].Value.ToString());
                    DAL DB = new DAL();
                    DB.deleteLoan(id);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }
    }


}
