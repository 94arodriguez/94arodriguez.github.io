using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace finalproject.Models
{
    public class Restaurant
    {
        public int RestaurantID {get; set;} //Primary Key

        [StringLength(60,MinimumLength = 3)]
        [Required]
        public string Name {get; set;}

        [StringLength(60,MinimumLength = 3)]
        [Required]
        public string Address {get; set;}

        [StringLength(25)]
        [Required]
        public string PhoneNumber {get; set;}

        [StringLength(20,MinimumLength = 3)]
        [Required]
        public string Cuisine {get; set;}
       
        public List<Review> Reviews {get; set;} //Navigation Property
    }
}