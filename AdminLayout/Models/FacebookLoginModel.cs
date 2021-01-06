using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AdminLayout.Models
{
    public class FacebookLoginModel
    {
        [Required]
        public string Email { get; set; }
        public ClaimsPrincipal Principal { get; set; }
    }
}
