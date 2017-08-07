using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace QualityBags.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public String Name { get; set; }
        public String PhoneNoHome { get; set; }
        public String PhoneNoMobile { get; set; }
        public String Address { get; set; }
        public bool Enabled { get; set; }
    }
}
