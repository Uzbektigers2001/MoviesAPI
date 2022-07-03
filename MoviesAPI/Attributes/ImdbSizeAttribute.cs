using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Attributes
{
    public class ImdbSizeAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            double? size = (double?)value; 
            return size is <= 10.0 and >= 0.0;
        }
    }
}
