using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using LibraryManagment.Classes;
namespace LibraryManagment.Forms
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            TextBox[] memberTxt = {
            txtEmail,
                txtFamily,
                txtMoblie
                ,txtName,
                txtPass
            ,txtNc,txtUserName,txtMoblie
            };
            ObjItems mem = new ObjItems{ MemberName=txtName.Text,
           MemberFamily = txtFamily.Text,
           MemberNc = txtNc.Text,
           MemberEmail = txtEmail.Text,
           MemberPhone= txtMoblie.Text,
           MemberUserName = txtUserName.Text,
           MemberPass = txtPass.Text};
           
            try
            {
                BLL bl = new BLL();
                bl.AddMembers(memberTxt,mem);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
