using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Data.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }      
        public int? PrefixID { get; set; }
        public Prefix Prefix { get; set; }
        [MaxLength(50)]        
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [MaxLength(50)]        
        public string LastName { get; set; }        
        public int? SuffixID { get; set; }
        public Suffix Suffix { get; set; }
        public string Username { get; set; }
        public string NormalizedUsername { get; set; }
        [MaxLength(256)]
        public string Email { get; set; }
        [MaxLength(256)]
        public string NormalizedEmail { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
