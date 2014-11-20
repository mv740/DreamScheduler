﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DreamSchedulerApplication.Models
{

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }

    public class RegisterViewModel
    {
        //"The {0} must be at least {2} characters long.", MinimumLength = 5
        [Required(ErrorMessage = "Username is required")]
        [StringLength(100, ErrorMessage = "The {0} must be between {2} and  {1} characters long.", MinimumLength = 5)]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be between {2} and  {1} characters long.", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Your first name is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Your last name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Your student ID is required")]
        [Display(Name = "Student ID")]
        public int StudentID { get; set; }

        [Range(0.0, 4.3, ErrorMessage= "Your GPA must be between 0 and 4.3")]
        [Required(ErrorMessage = "Your GPA is required")]
        [Display(Name = "GPA")]
        public int GPA { get; set; }
    }
}