using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Appointment_Scheduler.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Display(Name ="Confirm Passwrord")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
      


    }
}
