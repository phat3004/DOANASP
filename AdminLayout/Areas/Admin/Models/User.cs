﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLayout.Areas.Admin.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
        public string Avatar { get; set; }

        public ICollection<OrderModel> listOrder { get; set; }

    }
}
