using System.ComponentModel.DataAnnotations;

namespace WebAPI.Data.Models
{
    public class Prefix
    {
        [Key]
        public int PrefixID { get; set; }
        [MaxLength(20)]
        public string Description { get; set; }
    }
}
