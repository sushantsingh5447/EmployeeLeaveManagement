using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Holiday_Tracking_Tool.Models
{
    public class Login
    {
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }

    }
}