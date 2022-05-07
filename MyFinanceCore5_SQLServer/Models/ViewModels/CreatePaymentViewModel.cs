using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.ViewModels
{
    public class CreatePaymentViewModel
    {
        [Required(ErrorMessage = "Campo {0} obrogatório")]
        [Display(Name = "Nome")]
        public string Name { get; set; }


        public int UserId { get; set; }

        [Required(ErrorMessage = "Campo {0} obrogatório")]
        [Display(Name = "Bandeira")]
        public int TypepaymentId { get; set; }

    }
}
