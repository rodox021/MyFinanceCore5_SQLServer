using MyFinanceCore5_SQLServer.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.ViewModels
{
    public class ShopViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Display(Name = "Loja")]        
        public string Store { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Display(Name = "Data da Compra")]
        public DateTime DatePurchase { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Display(Name = "Produto")]
        public string Product { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Display(Name = "Valor")]
        public double Price { get; set; }


        //RelationShip

        //CardUser
        [Required(ErrorMessage = "Campo {0} obrigatório")]     
        [Display(Name = "Dependente")]
        public int CardUserId { get; set; }

        //Payment
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Display(Name = "Método de Pagamento")]
        public int PaymentId { get; set; }

        //User
        public int UserId { get; set; }

        //Installment
        public List<InstallmentBuy> InstallmentBuys { get; set; }

    }
}
