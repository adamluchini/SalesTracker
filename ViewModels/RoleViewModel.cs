using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSalesTracker.ViewModels
{
    public class RoleViewModel
    {
        [Required]
        [Display(Name = "RoleName")]
        public string RoleName { get; set; }
    }
}
