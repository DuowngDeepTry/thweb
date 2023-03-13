using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using VuDaiDuong_8627.Models;

namespace VuDaiDuong_8627.ViewModels
{
    public class CourseViewModels
    {
        [Required (ErrorMessage ="VUI LÒNG KHÔNG ĐỂ TRỐNG")]
        public string Place { get; set; }
        [Required(ErrorMessage = "VUI LÒNG KHÔNG ĐỂ TRỐNG")]
        [FutureData]
        public string Date { get; set; }
        [Required(ErrorMessage = "VUI LÒNG KHÔNG ĐỂ TRỐNG")]
        public string Time { get; set; }
        [Required(ErrorMessage = "VUI LÒNG KHÔNG ĐỂ TRỐNG")]
        public byte Category { get; set; }  
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}