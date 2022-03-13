using MyFinanceCore5_SQLServer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.Entity
{
    public class User : IBaseEntity
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo {0} deve ter entre {2} - {1} caracters")]
        public string Name { get; set; }


        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public string Password { get; set; }


        public bool IsActive { get; set; } = true;


        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        private DateTime? CreateAt;


        public DateTime? CreatAt
        {
            get { return CreateAt; }
            set { CreateAt = value == null ? DateTime.Now : value; }
        }


        public DateTime? UpdateAt { get; set; }
        public DateTime? DeletedAt { get; set; }


        //RelationShip

        //CardUSer - Dependente do cartão ou pessoas que usaram o cartão 
        public List<CardUser>CardUsers{ get; set; }

       
        
        //Profiles
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        //FixedBill
       
        public List<FixedBill> FixedBills { get; set; }

        //Shop

        public List<Shop> Shops { get; set; }

        //Type Fixed bills - tipo de conta fixa

        public List<TypeFixedBill> TypeFixedBills { get; set; }


        //Type Input - tipo de entrada

        public List<TypeInput> TypeInputs { get; set; }


        //Type Payment - tipo de entrada

        public List<TypePayment> TypePayments { get; set; }





    }
}
