using MyFinanceCore5_SQLServer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.Entity
{
    public class TypeInput:IBaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo {0} obrigatório")]
        [Display(Name ="Nome da Entrada")]
        public string Name { get; set; }

        //TypeInput
        public List<Input> Inputs { get; set; }

        public TypeInput()
        {
        }

        public TypeInput(string name, int userID)
        {
            Name = name;
            UserID = userID;
        }



        //Relationship
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
