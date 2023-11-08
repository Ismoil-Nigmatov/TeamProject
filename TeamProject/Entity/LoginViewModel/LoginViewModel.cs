﻿using System.ComponentModel.DataAnnotations;

namespace TeamProject.Entity.LoginViewModel
{
    public class LoginViewModel
    {

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password  { get; set; }

    }
}
