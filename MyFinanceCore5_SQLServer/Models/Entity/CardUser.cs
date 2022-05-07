using MyFinanceCore5_SQLServer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.Entity
{
    public class CardUser:IBaseEntity
    {
        public CardUser()
        {
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //Relationship

        public int UserID { get; set; }
        public User User { get; set; }

        public CardUser(string name, int userID)
        {
            Name = name;
            UserID = userID;
        }
    }
}
