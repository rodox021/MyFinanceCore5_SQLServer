using MyFinanceCore5_SQLServer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.Entity
{
    public class PictureIcon:IBaseEntity
    {
        [Key]
        public int Id { get; set; }



        //------------------------------------------------
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo {0} Obrigatório")]
        public string Name { get; set; }



        //------------------------------------------------
        [Display(Name = "Icone")]
        [Required(ErrorMessage = "Campo {0} Obrigatório")]
        public string IconClass { get; set; }




        //------------------------------------------------


        //Relationship

        public List<TypePayment> TypePayments { get; set; }


        public PictureIcon() { }

        public PictureIcon(string name, string iconClass)
        {
           
            Name = name;
            IconClass = iconClass;
        }
    }
}
