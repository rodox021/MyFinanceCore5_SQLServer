using MyFinanceCore5_SQLServer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.Entity
{
    public class Shop:IBaseEntity
    {
        [Key]
        public int Id { get; set; }


        public string Store { get; set; }
        public DateTime DatePurchase { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }


        //RelationShip

        //CardUser
        public int CardUserId { get; set; }
        public CardUser CardUser { get; set; }

        //Payment
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }

        //User
        public int UserId { get; set; }
        public User User { get; set; }

        //Installment
        public List<InstallmentBuy> InstallmentBuys { get; set; }

        public Shop() {}

        public Shop(string store, DateTime datePurchase, string product, double price, int cardUserId, int paymentId, int userId)
        {
            Store = store;
            DatePurchase = datePurchase;
            Product = product;
            Price = price;
            CardUserId = cardUserId;
            PaymentId = paymentId;
            UserId = userId;
        }
    }
}
