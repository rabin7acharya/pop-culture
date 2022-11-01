using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCulture.Models.ViewModels
{
    public class ProductVM
    {

        public Product Product { get; set; }
        //for category list
        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        //for wear type list
        [ValidateNever]
        public IEnumerable<SelectListItem> WearTypeList { get; set; }
    }
}
