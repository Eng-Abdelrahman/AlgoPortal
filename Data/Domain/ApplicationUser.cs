using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsActive { get; set; }
    }
}
