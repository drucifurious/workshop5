﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace workshop5.Models
{
    public partial class Customers
    {
        public int CustomerId { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustAddress { get; set; }
        public string CustCity { get; set; }
        public string CustProv { get; set; }
       
        [Required(ErrorMessage = "Postal Code is Required")]
        [RegularExpression(@"^([A-Z]\d[A-Z])\ {0,1}(\d[A-Z]\d)$", ErrorMessage = "Invalid Postal Code")]
        public string CustPostal { get; set; }
        public string CustCountry { get; set; }
        public string CustHomePhone { get; set; }
        public string CustBusPhone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email", Prompt = "Enter your email")]
        public string CustEmail { get; set; }
        public int AgentId { get; set; }

        
        [DataType(DataType.Password)]
        [Display(Name = "Password", Prompt = "Enter your password")]
        public string PasswordNotHashed { get; set; }

        [NotMapped]
        [Compare("PasswordNotHashed", ErrorMessage = "Password doesn't match.")]
        public string ConfirmPassword { get; set; }
        public byte[] PasswordHashed { get; set; }
        public string PasswordSalt { get; set; }




    }
}
