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
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime DueDate { get; set; }


        //RelationShip

        //User
        public int UserId { get; set; }
        public User User { get; set; }

        //TypePayment


        public int TypePaymentId { get; set; }
        public TypePayment TypePayment { get; set; }

        //shop

        public List<Shop> Shops { get; set; }

    }
}
