using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finalproject.Models
{
    public class Review
    {
        public int ReviewID {get; set;} //Primary Key

        [Range(1,5)]
        [Required]
        public int ReviewNum {get; set;}

        [Display(Name = "Restaurant")]
        [Required]
        public int RestaurantID {get; set;} // Foreign Key
        public Restaurant Restaurant {get; set;} // Navigation Property
    }
}