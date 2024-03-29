﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCForm.UI.Web.Models.VM
{
    public class AdminUserVM
    {
        [Required(ErrorMessage = "Username alanı boş geçilemez")]       
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Parola alanı boş geçilemez")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Parola tekrar alanı boş geçilemez")]
        [Compare("Password", ErrorMessage = "Parolalar uyuşmuyor")]
        [Display(Name = "Şifre Tekrar")]
        public string ConfrimPassword { get; set; }
    }
}