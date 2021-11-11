﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PSI_WEB_APP.Models
{
    public class Criminal
    {
        [Required(ErrorMessage = "National ID is required")]
        [DataType(DataType.Text)]
        [Display(Name = "National ID")]
        public int NationalID { get; set; }

        [Required(ErrorMessage = "Passport is required")]
        [DataType(DataType.Text)]
        [Display(Name = "Passport No")]
        public int PassPortNo { get; set; }

        [Required(ErrorMessage = "Crime Title is required")]
        [DataType(DataType.Text)]
        [Display(Name = "Crime Title")]
        public String Crime { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [DataType(DataType.Text)]
        [Display(Name = "Description ")]
        public String Description { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Text)]
        [Display(Name = "Date")]
        public String CrimeDate { get; set; }

    }
}
