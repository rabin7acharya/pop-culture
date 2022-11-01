using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCulture.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        public string Size { get; set; }

        [Required]
        public string BrandName { get; set; }
        
        [Required]
        public double Price { get; set; }

        [ValidateNever]
        public string ImageUrl { get; set; }
        
        [Required]
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }
        
        [Required]
        public int WearTypeId { get; set; }
        [ValidateNever]
        public WearType WearType { get; set; }

    }
}
