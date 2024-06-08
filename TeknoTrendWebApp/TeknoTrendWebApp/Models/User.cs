﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TeknoTrendWebApp.Models.Base;

namespace TeknoTrendWebApp.Models
{
    public class User : Entity
    {
        [Display(Name = "Isim")]
        [Required(ErrorMessage = "Alan boş bırakılamaz")]
        [StringLength(maximumLength: 75, ErrorMessage = "En fazla 75 karakter olmalıdır")]
        public string Name { get; set; }

        [Display(Name = "Soyisim")]
        [StringLength(maximumLength: 75, ErrorMessage = "En fazla 75 karakter olmalıdır")]
        public string Surname { get; set; }

        [Display(Name = "E-Posta")]
        [StringLength(maximumLength: 150, ErrorMessage = "En fazla 150 karakter olmalıdır")]
        public string Email { get; set; }

        [Display(Name = "Telefon")]
        [StringLength(maximumLength: 150, ErrorMessage = "En fazla 150 karakter olmalıdır")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Alan boş bırakılamaz")]
        [StringLength(maximumLength: 20, ErrorMessage = "En fazla 20 karakter olmalıdır")]
        public string Password { get; set; }

        [Display(Name = "Adres")]
        [StringLength(maximumLength: 75, ErrorMessage = "En fazla 250 karakter olmalıdır")]
        public string Address { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }

        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}