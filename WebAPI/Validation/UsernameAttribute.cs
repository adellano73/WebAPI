using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WebAPI.Validation
{
    public class UsernameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value) 
        {
            return Regex.IsMatch((string)value, @"^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$", RegexOptions.IgnoreCase);
        }
    }
}