using MyFinanceCore5_SQLServer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.Entity
{
    public class FixedBill:IBaseEntity
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


        //Relationship


        //User
        public int UserId { get; set; }
        public User User { get; set; }

        //TypeFixdBills
        public int TypeFixedBillId { get; set; }
        public TypeFixedBill TypeFixedBill { get; set; }

    }
}
