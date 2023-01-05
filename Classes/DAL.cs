using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryManagment.Forms;
using System.Threading.Tasks;

using System.Windows.Forms;
using Library_Manag.modules;

using System.Data.Entity.Validation;

namespace LibraryManagment.Classes
{
    public class DAL : ObjItems
    {
        libraryDBEntities ctx = new libraryDBEntities();
        public void findUser(ObjItems obj)
        {
            var user = ctx.Members.Where(p => p.Name == obj.name && p.Password == obj.pass).FirstOrDefault();
            if (user != null)
            {
                Main m = new Main();
                m.Show();
            }
            else
            {
                MessageBox.Show("کاربر هنوز ثبت نام نکرده است");
            }

        }

        public void AddShelf(ObjItems obj)
        {
            Shelf sh = new Shelf { ShelfName = obj.ShelfName };
            ctx.Shelves.Add(sh);
            ctx.SaveChanges();
            MessageBox.Show("قفسه جدید با موفقیت ثبت شد!");
            obj.Reset(NewShelf.ActiveForm);
        }
        public void ShelfLists(ComboBox c)
        {
            var shelfs = ctx.Shelves.ToList();
            c.DisplayMember = "ShelfName";
            c.ValueMember = "ShelfId";
            c.DataSource = shelfs;

        }
        public void AddBook(ObjItems obj)
        {
            try
            {
                Book book = new Book();
                book.BookName = obj.BookName;
                book.Auther = obj.BookAuther;
                book.Publisher = obj.BookPublisher;
                book.Count = obj.BookCount;
                book.Shabak = obj.BookShabak;

                book.ShelfShelfId = int.Parse(obj.BookShlefId);
                ctx.Books.Add(book);
                ctx.SaveChanges();
                MessageBox.Show("کتاب جدید با موفقیت افزوده شد");
                obj.Reset(ff: Form.ActiveForm);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + "خطای دیتابیس رخ داده است");
            }
        }
        public void bookGridShow(DataGridView DGV)
        {

            DGV.DataSource = ctx.Books.Select(p => new
            {
                p.BookName,
                p.Publisher,
                p.Auther,
                p.Shabak,
                p.Count,
                p.id
            }).ToList();

        }
        public void bookGridShowFilter(DataGridView DGV, int shelfSelected)
        {

            DGV.DataSource = ctx.Books.
                Where(p => p.ShelfShelfId == shelfSelected)
                .Select(p => new
                {
                    p.BookName,
                    p.Publisher,
                    p.Auther,
                    p.Shabak,
                    p.Count,
                }).ToList();

        }
        public void AddLoan(ObjItems obj)
        {
            try
            {
                Loan lo = new Loan();
                var user = ctx.Members.Where(p => p.NC == obj.MemberNc).FirstOrDefault();
                if (user == null)
                {
                    throw new Exception("\nشخص مورد نظر عضو کتابخانه نیست");
                }
                lo.Member_id = user.id;
                Book book = ctx.Books.Where(p => p.Shabak == obj.BookShabak.ToString()).FirstOrDefault();
                if (book == null)
                {
                    throw new Exception("\nکتاب مورد نظر یافت نشد ");
                }
                lo.LoanDate = obj.persianDate();
                lo.Book_id = Convert.ToInt32(book.id);
                book.Count--;
                ctx.Loans.Add(lo);
                ctx.SaveChanges();
                MessageBox.Show("امانت با موفقیت ثبت شد");

                LoanManage lm = new LoanManage();
                Form.ActiveForm.Close();
                lm.Show();
            }
            //catch (DbEntityValidationException ex)
            //{
            //    foreach (var eve in ex.EntityValidationErrors)
            //    {
            //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
            //                ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }
            //    throw new Exception("خطای دیتا بیس");

            //}
            catch (Exception ex)
            {
                throw new Exception("خطایی رخ داده است " + ex.Message);
            }
        }

        public void SignMember(ObjItems obj)
        {
            Member m = new Member
            {
                Name = obj.MemberName,
                Family = obj.MemberFamily,
                Mobile = obj.MemberPhone,
                NC = obj.MemberNc,
                UserName = obj.MemberUserName,
                Password = obj.MemberPass,
                Email = obj.MemberEmail,
                RollRollId = 2,
            };
            try
            {
                ctx.Members.Add(m);
                ctx.SaveChanges();
                MessageBox.Show("کاربر جدید با موفقیت ذخیره شد");
                obj.Reset(ff: Form.ActiveForm);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void MemberList(DataGridView DGV)
        {
            try
            {
                var members = ctx.Members.Select(
               p => new
               {
                   p.id,
                   p.Name,
                   p.Family,
                   p.Mobile,
                   p.NC,
                   p.Email,
                   p.UserName,
                   p.Roll.RollName
               }
               ).ToList();
                DGV.DataSource = members;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void deleteLoan(int id)
        {
            var selLoan = ctx.Loans.Where(p => p.id == id).FirstOrDefault();
            try
            {
                var result = MessageBox.Show("آیا از حذف آیتم مورد نظر اطمینان دارید ؟", "حذف امانت", MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    ctx.Loans.Remove(selLoan);
                    ctx.SaveChanges();
                    MessageBox.Show("آیتم مورد نظر حذف شد", "حذف امانت");
                    Form.ActiveForm.Close();
                    LoanManage lg = new LoanManage();
                    lg.Show();
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + "خطای دیتا بیس رخ داده \n");
            }
        }

        public void deleteBook(int id)
        {
            try
            {
              var result=  MessageBox.Show("آیا از حذف کتاب اطمینان دارید", "حذف کتاب", MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    var book = ctx.Books.Where(p => p.id == id).FirstOrDefault();
                    ctx.Books.Remove(book);
                    ctx.SaveChanges();
                    MessageBox.Show("کتاب مورد نظر حذف گردید","حذف کتاب");
                    Form.ActiveForm.Close();
                    BookManage lg = new BookManage();
                    lg.Show();
                }
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message  + " خطایی رخ داده است \n");
            }
        }

        public void deleteShelf(int id)
        {
           var result= MessageBox.Show("آیا از حذف آیتم اطمینان دارید؟","حذف دسته بندی",MessageBoxButtons.YesNo);
            try
            {
                if (result == DialogResult.Yes)
                {
                    var shelf = ctx.Shelves.Where(p => p.ShelfId == id).FirstOrDefault();
                    ctx.Shelves.Remove(shelf);
                    ctx.SaveChanges();

                    MessageBox.Show("آیتم مورد نظر با موفقیت حذف شد", "حذف دسته بندی");
                    Form.ActiveForm.Close();
                    Shelfs sh = new Shelfs();
                    sh.Show();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + " خطایی رخ داده است \n");
            }
        }
        public void deleteMember(int id)
        {
            var member = ctx.Members.Where(p=>p.id==id).FirstOrDefault();
            var result = MessageBox.Show("آیا از حذف آیتم مورد نظر اطمینان دارید؟","حذف کاربر",MessageBoxButtons.YesNo);
            try
            {
                if (result == DialogResult.Yes)
                {
                    ctx.Members.Remove(member);
                    ctx.SaveChanges();
                    MessageBox.Show("کاربر مورد نظر با موفقیت حذف گردید", "حذف کاربر ");
                    Form.ActiveForm.Close();
                    memberManag mg = new memberManag();
                    mg.Show();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + " خطایی رخ داده است \n");
            }
        }
    }

}
