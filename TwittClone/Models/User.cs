﻿using Microsoft.AspNetCore.Identity;

namespace TwittClone.Models
{
    public class User : IdentityUser
    {
        public string DisplayName { get; set; }
        public string Bio { get; set; }
        public string ProfilePicURL { get; set; }



    }
}
