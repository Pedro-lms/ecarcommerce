using System.ComponentModel.DataAnnotations;

namespace ecommerce.src.Common.ViewModels
{
    public class AddFundsBindingModel
    {
        public string UserId { get; set; }

        [Required(ErrorMessage = "Entre um valor correto, por favor!")]
        [Range(1, double.MaxValue, ErrorMessage = "Não é possível transferir valor menor que 1 real!")]
        public decimal Balance { get; set; }
    }
}
