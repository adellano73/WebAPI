using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WebAPI.Validation
{
    public class FirstNameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value) 
        {
            return Regex.IsMatch((string)value, @"^[a-z ,.'-]+$", RegexOptions.IgnoreCase);
        }
    }
}