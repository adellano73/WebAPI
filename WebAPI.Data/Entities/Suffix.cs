using System.ComponentModel.DataAnnotations;

namespace WebAPI.Data.Models
{
    public class Suffix
    {
        [Key]
        public int SuffixID { get; set; }
        public string Description { get; set; }
    }
}
