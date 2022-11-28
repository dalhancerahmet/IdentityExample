﻿using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain
{
    public class AppUser : IdentityUser<string>
    {
        public string UserName { get; set; }
    }
}