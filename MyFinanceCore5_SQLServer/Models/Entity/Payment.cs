using MyFinanceCore5_SQLServer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.Entity
{
    public class Payment:IBaseEntity
    {
        public Payment()
        {
        }

        [Key]
        public int Id { get; set; }

        [Display(Name ="Nome")]
        public string Name { get; set; }
        public DateTime DueDate { get; set; }


        //RelationShip

        //User
        public int UserId { get; set; }
        public User User { get; set; }

        //TypePayment


        public int TypePaymentId { get; set; }

        [Display(Name = "Bandeira")]
        public TypePayment TypePayment { get; set; }

        //shop

        public List<Shop> Shops { get; set; }

        public Payment(string name,  int userId, int typePaymentId)
        {
            Name = name;
           
            UserId = userId;
            TypePaymentId = typePaymentId;
        }
    }
}
