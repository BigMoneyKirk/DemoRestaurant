using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Diner;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC2.Models
{
    public class Cart
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Customername { get; set; }
        public string Phone { get; set; }
        public FoodItem Food { get; set; }
    }
}