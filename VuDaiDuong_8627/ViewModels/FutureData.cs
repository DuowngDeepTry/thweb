using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace VuDaiDuong_8627.ViewModels
{
    public class FutureData : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),"dd/M/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None, out dateTime);
            return (isValid && dateTime > DateTime.Now);
        }
    }
}