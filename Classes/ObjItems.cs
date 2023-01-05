using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagment.Classes
{
    public class ObjItems
    {
        public string name { get; set; }
        public string pass { get; set; }
        public string ShelfName { get; set; }
        public string BookName { get; set; }
        public string BookAuther { get; set; }
        public string BookPublisher { get; set; }
        public string BookShabak { get; set; }
        public int BookCount { get; set; }
        public string BookShlefId { get; set; }
        //*************************************member 7options***********************
        public string MemberEmail { get; set; }
        public string MemberName { get; set; }
        public string MemberFamily { get; set; }
        public string  MemberPhone { get; set; }
        public string  MemberUserName { get; set; }
        public string MemberPass { get; set; }
        public string MemberNc { get; set; }
        //****************************************************************************
        public void Reset(Form ff)
        {
            foreach (Control c in ff.Controls)
            {
                if (c.GetType().Name == "TextBox")
                {
                    c.Text = "";
                }
            }
          
        }
        //****************************************************************************
        PersianCalendar pc = new PersianCalendar();
        public string persianDate()
        {
            string year = pc.GetYear(DateTime.Now).ToString();
            string month = pc.GetMonth(DateTime.Now).ToString();
            string day = pc.GetDayOfMonth(DateTime.Now).ToString();
            string fullRetDate = year + "/" + month + "/" + day;
            return fullRetDate;
        }
       

    }

}
