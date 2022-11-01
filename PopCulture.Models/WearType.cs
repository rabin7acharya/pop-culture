using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCulture.Models
{
    public class WearType
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Wear Type")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
