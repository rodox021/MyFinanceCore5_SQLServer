using MyFinanceCore5_SQLServer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.Entity
{
    public class InstallmentTypeInput:IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int NumberOfInstallment { get; set; }
        public double PriceOfInstallment { get; set; }


        //Relationship

        //Input
        public int InputId { get; set; }
        public Input Input { get; set; }

    }
}
