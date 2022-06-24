using ecommerce.src.Models;
using System.ComponentModel.DataAnnotations;

namespace ecommerce.src.Common.ViewModels
{
    public class CompareCarsViewModel
    {
        [Required]
        public Car FirstCar { get; set; }
        [Required]
        public Car SecondCar { get; set; }

    }
}
