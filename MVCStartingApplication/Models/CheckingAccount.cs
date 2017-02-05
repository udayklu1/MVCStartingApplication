﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCStartingApplication.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Display(Name = "Account #")]
        public string AccountNumber { get; set; }
        [Display(Name = "First name")]
        public String FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return String.Format("{0} {1}", this.FirstName, LastName);
            }
        }
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
    }
}