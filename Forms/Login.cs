using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagment.Classes;
using LibraryManagment.modules;

namespace LibraryManagment.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        libraryDBEntities ctx = new libraryDBEntities();
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                BLL biz = new BLL();
                biz.validate(new ObjItems
                {
                    name = txtUserName.Text,
                    pass = txtPass.Text
                });
            }
            catch (Exception ep)
            {

                MessageBox.Show(ep.Message);
            }
            
           

            //*********
            //if (txtUserName.Text != "" && txtPass.Text != "")
            //{
            //    string userName = txtUserName.Text;
            //    string pass = txtPass.Text;
            //    Member user = ctx.Members.Where(p => p.UserName == userName && p.Password == pass).FirstOrDefault();
            //    if (user != null)
            //    {
            //        Main m = new Main();
            //        m.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("user not found");
            //    }
            //}
            //else
            //{
            //    errorProvider1.SetError(txtUserName, "input cant be null");
            //    errorProvider1.SetError(txtPass, "input cant be null");
            //}

            //*********
        }
    }
}
