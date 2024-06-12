using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class login
    {
        [Key]
        public string uname { get; set; }
        public string upass { get; set; }

    }
}
