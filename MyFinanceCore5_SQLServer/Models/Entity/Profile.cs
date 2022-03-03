using MyFinanceCore5_SQLServer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.Entity
{
    public class Profile:IBaseEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


        //Relationship

        public List<User> Users { get; set; }

    }
}
