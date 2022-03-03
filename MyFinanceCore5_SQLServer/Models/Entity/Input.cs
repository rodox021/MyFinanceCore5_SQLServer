using MyFinanceCore5_SQLServer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.Entity
{
    public class Input:IBaseEntity
    {

        [Key]
        public int Id { get; set; }

        
        [Required(ErrorMessage ="Campo {0} obrigatório")]
        public double Value { get; set; }



        [Required(ErrorMessage = "Campo {0} obrigatório")]
        public DateTime DueDate { get; set; }



        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [StringLength(150, MinimumLength =3, ErrorMessage =("O campo deve ter entre {2}-{1} caracteres"))]
        public string  Description{ get; set; }



        //Relationship

        //User
        public int UserID { get; set; }
        public User User { get; set; }

        //TypeInput
        public int TypeInputId { get; set; }
        public TypeInput TypeInput { get; set; }

        //IntallmentTyeImput

        public List<InstallmentTypeInput> InstallmentTypeInput { get; set; }


    }
}
