using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WebAPI.Validation
{
    public class PasswordAttribute : ValidationAttribute
    {
        public override bool IsValid(object value) 
        {
            return Regex.IsMatch((string)value, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,})");
        }
    }
}