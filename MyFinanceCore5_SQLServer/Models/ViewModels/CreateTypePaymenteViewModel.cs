using MyFinanceCore5_SQLServer.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.ViewModels
{
    public class CreateTypePaymenteViewModel
    {
        [Required(ErrorMessage = "Campo {0} obrogatório")]
        [Display(Name = "Bandeira")]
        public string FlagCard { get; set; }




        [Required(ErrorMessage = "Campo {0} obrogatório")]
        [Display(Name = "Icone")]
        public int PictureIconId { get; set; }



        [Required(ErrorMessage = "Campo {0} obrogatório")]
        [Display(Name = "Usuario")]
        public int UserId { get; set; }


    }
}
