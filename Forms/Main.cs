using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagment.Forms;
namespace LibraryManagment.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shelfs shelfs = new Shelfs();
            shelfs.Show();
            

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {

            BookManage bm = new BookManage();
            bm.Show();
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            
            LoanManage al = new LoanManage();
            al.Show();

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            memberManag mg = new memberManag();
            mg.Show();

        }

      
    }
}
