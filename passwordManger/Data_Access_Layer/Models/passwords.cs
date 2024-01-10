using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Password's name")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        

        public string URL { get; set; }

        [Required]
        [DisplayName("Password")]

        public string PassWord { get; set; }

        
    }
}
