using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using VuDaiDuong_8627.Models;

namespace VuDaiDuong_8627.ViewModels
{
    public class CourseViewModels
    {
        public string Place { get; set; }   
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }  
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}