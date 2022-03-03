using MyFinanceCore5_SQLServer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.Entity
{
    public class InstallmentBuy:IBaseEntity
    {
        [Key]
        public int Id { get; set; }

        public double TotalPrice { get; set; }
        public double PriceInstallment { get; set; }
        public int NumberOfInstallment { get; set; }



        //RelationShip
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
