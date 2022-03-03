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
        public string Name { get; set; }

        //TypeInput
        public List<Input> Inputs { get; set; }

    }
}
