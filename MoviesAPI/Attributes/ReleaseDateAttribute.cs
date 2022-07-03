using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Attributes
{
    public class ReleaseDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            DateTime? date = (DateTime?)value;
            var max = new DateTime(DateTime.Now.Year + 1,DateTime.Now.Month,DateTime.Now.Day);
            var min = new DateTime(DateTime.Now.Year - 60,DateTime.Now.Month,DateTime.Now.Day); 
            if(date <= max && date >= min)
            return true;
            return false;
        }
    }
}
