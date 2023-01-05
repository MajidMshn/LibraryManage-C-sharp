using LibraryManagment.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagment.Classes
{
    public class BLL
    {
        DAL DB = new DAL();
        
        string reg = @"[0-9a-zA-Zا-ی]";
        string numReg = @"[0-9]";
        string emailReg = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
        public void validate(ObjItems obj)
        {
            string strErr = string.Empty;

            int c = 1;
            if (string.IsNullOrWhiteSpace(obj.name))
            {
                strErr += c + " -ورود نام الزامیست\n";
                c++;
            }
            if (string.IsNullOrWhiteSpace(obj.pass))
            {
                strErr += c + " - ورود پسورد الزامیست\n";
                c++;
            }

            if (!string.IsNullOrEmpty(strErr))
            {
                throw new Exception(strErr);
            }

            DB.findUser(new ObjItems
            {
                name = obj.name,
                pass = obj.pass,
            });


        }
        //****************************************************************************
        public void validateInp(ObjItems obj)
        {
            string Err = string.Empty;
            if (!Regex.Match(obj.ShelfName, reg).Success)
            {
                Err = "فقط حروف و اعداد مجاز به ثبت می باشند !";
                throw new Exception(Err);
            }
            DB.AddShelf(new ObjItems { ShelfName = obj.ShelfName });
        }
        //****************************************************************************

        //****************************************************************************


        ErrorProvider er = new ErrorProvider();
        public void valid()
        {
            MessageBox.Show("Test");
        }
        public void ValidateItems(Control[] con, string shelId)
        {
            foreach (var item in con)
            {
                if (string.IsNullOrWhiteSpace(item.Text))
                {
                    er.SetError(item, "این فیلد الزامیست");
                    throw new Exception("تمامی فیلد ها تکمیل کنید");
                }
                er.Clear();
                if (!Regex.Match(item.Text, reg).Success)
                {
                    er.SetError(item, "مقدار وارد شده معتبر نیست");
                    throw new Exception("مقادیر وارد شده معتبر نیست");
                }
                er.Clear();



            }
            //MessageBox.Show($"0:{con[0]}\n 1:{con[1]}\n 2:{con[2]} \n3:{con[3]}\n 4:{con[4]}\n".ToString());
            DB.AddBook(new ObjItems
            {
                BookName = con[0].Text,
                BookAuther = con[1].Text,
                BookPublisher = con[2].Text,
                BookShabak = con[3].Text,
                BookCount = int.Parse(con[4].Text),
                BookShlefId = shelId
            });




        }
        //****************************************************************************
        //**********************************ADD LOAN**************************
        public void AddLoan(ObjItems obj)
        {
            string loErr = null;
            if (!Regex.Match(obj.BookShabak.ToString(), numReg).Success && !Regex.Match(obj.MemberNc, numReg).Success)
            {
                loErr += "مقادیر ورودی صحیح نیست لطفا اصلاح کرده و دوباره تلاش کنید";
                throw new Exception(loErr);
            }

            DB.AddLoan(new ObjItems { BookShabak = obj.BookShabak, MemberNc = obj.MemberNc });
        }
        int flag = 0; int flag2 = 0;
       int flag3 = 0;
        public void AddMembers(TextBox[] memTxt,ObjItems obj)
        {


            foreach (var c in memTxt)
            {
                er.Clear();
                if (string.IsNullOrEmpty(c.Text))
                {
                    er.SetError(c, "فیلد الزامی");
                    flag++;
                }
                if (!Regex.Match(c.Text, reg).Success)
                {
                    er.SetError(c, "عدم تطابق الگو");
                    flag2++;
                }
               


            }
            if (!Regex.Match(memTxt[0].Text,emailReg).Success )
            {
                flag3++;
                er.SetError(memTxt[0], "ایمیل وارد شده معتبر نیست");
                throw new Exception("ایمیل معتبر نیست");
                flag3 = 0;
            }
            if (flag > 0)
            {
                flag = 0;
                throw new Exception("پرکردن فیلد ها الزامیست");
            }
            if (flag2 > 0)
            {
                flag2 = 0;
                throw new Exception("مقادیر وارد شده نامعتبر است ");
            }
            if (flag == 0 && flag2==0 && flag3==0)
            {
             
                DB.SignMember(obj);
           }
           




        }
    }
}

