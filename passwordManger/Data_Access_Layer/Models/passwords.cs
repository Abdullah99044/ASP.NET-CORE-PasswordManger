using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class passwords
    {
        [Key] 
        
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }

        [Required]

        public string URL { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]

        public byte[] PasswordSalt { get; set; }

        [Required]

        public string PasswordStrength { get; set;}
    }
}
