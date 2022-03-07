using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyFinanceCore5_SQLServer.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Data
{
    public class SeedIniatializer
    {
        public static void Seed(IApplicationBuilder applicationsBuilder)
        {
            using (var serviceScope = applicationsBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();


                context.Database.EnsureCreated();


                //Icon
                if (!context.PictureIcons.Any())
                {
                    context.PictureIcons.AddRange(new List<PictureIcon>()
                    {
                     new PictureIcon("MASTERCARD", "fab fa-cc-mastercard"),
                     new PictureIcon("VISA", "fab fa-cc-visa"),
                     new PictureIcon("AMERICAM EXPRESS", "fab fa-cc-amex"),
                     new PictureIcon("DÉBITO", "far fa-credit-card"),
                     new PictureIcon("CASH", "far fa-money-bill-alt"),
                     new PictureIcon("PayPal", "fab fa-paypal"),
                     new PictureIcon("DEFAULT", "far fa-credit-card")
                     });
                    context.SaveChanges();
                }

                if (!context.TypeFixedBills.Any())
                {
                    context.TypeFixedBills.AddRange(new List<TypeFixedBill>()
                    {
                        new TypeFixedBill("Luz"),
                        new TypeFixedBill("Internet"),
                        new TypeFixedBill("Celular"),
                        new TypeFixedBill("Educação"),
                        new TypeFixedBill("Lazer")


                    });
                    context.SaveChanges();
                }

                if (!context.TypePayments.Any())
                {
                    context.TypePayments.AddRange(new List<TypePayment>()
                    {
                        new TypePayment("Itau Platinun",1 ),
                        new TypePayment("Itau VISA",2 ),
                        new TypePayment("Sansung Card",2 ),
                        new TypePayment("NuBank",1 )


                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
