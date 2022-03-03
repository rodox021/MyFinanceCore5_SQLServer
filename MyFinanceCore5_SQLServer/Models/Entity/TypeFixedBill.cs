using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.Entity
{
    public class TypeFixedBill:IbaseEntity
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


        //Relationship
        public List<FixedBill> FixedBills { get; set; }

    }
}
