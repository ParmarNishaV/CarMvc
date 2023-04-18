using System;
using System.ComponentModel.DataAnnotations;

namespace GiriajCarModel.Models
{
	public class CarModel : BaseModel
	{
        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public bool New { get; set; }
    }
}

