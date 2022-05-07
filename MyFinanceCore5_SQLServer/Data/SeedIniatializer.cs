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




                //Profile ------------------------------------
                if (!context.Profiles.Any())
                {
                    context.Profiles.AddRange(new List<Profile>()
                    {
                        new Profile()
                        {
                            Name = "Manager"
                        },
                         new Profile()
                        {
                            Name = "Admin"
                        },
                          new Profile()
                        {
                            Name = "User"
                        }
                    });
                    context.SaveChanges();
                }


                //User ------------------------------------
                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<User>() {

                        new User()
                        {
                            Name = "Admin",
                            Email = "admin@admin.com",
                            Password = "admin",
                            IsActive = true,
                            CreatAt = DateTime.Now,
                            ProfileId = 1
                        },
                         new User()
                        {
                            Name = "Usuario",
                            Email = "usuario@usuario.com",
                            Password = "usuario",
                            IsActive = true,
                            CreatAt = DateTime.Now,
                            ProfileId = 3
                        }
                    });
                    context.SaveChanges();
                }
                //Icon ------------------------------------
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

                //Type Fixed Bils ------------------------------------
                if (!context.TypeFixedBills.Any())
                {
                    context.TypeFixedBills.AddRange(new List<TypeFixedBill>()
                    {
                        new TypeFixedBill("Luz",1),
                        new TypeFixedBill("Internet",1),
                        new TypeFixedBill("Celular",1),
                        new TypeFixedBill("Educação",1),
                        new TypeFixedBill("Lazer",1)


                    });
                    context.SaveChanges();
                }


                //Type Payment ------------------------------------
                if (!context.TypePayments.Any())
                {
                    context.TypePayments.AddRange(new List<TypePayment>()
                    {
                        new TypePayment("Mastercard",3 ,1),
                        new TypePayment("VISA",2 ,1),
                         new TypePayment("Débito",4 ,1),


                    });
                    context.SaveChanges();
                }

                // payment

                if (!context.Payments.Any())
                {
                    context.Payments.AddRange(new List<Payment>()
                    {
                        new Payment("Itau Platinum", 1, 3),
                        new Payment("Itau Internacional", 1, 2)
                    });

                    context.SaveChanges();
                }

                //Type Inputs

                if (!context.TypeInputs.Any())
                {
                    context.TypeInputs.AddRange(new List<TypeInput>()
                    {
                        new TypeInput("Salário fixo",1),
                        new TypeInput("Extra",1),
                        new TypeInput("Pgto Juliana",1 ),
                        new TypeInput("Venda de Produto",1)


                    });
                    context.SaveChanges();
                }

                // Card User

                if (!context.CardUsers.Any())
                {
                    context.CardUsers.AddRange(new List<CardUser>()
                    {
                        new CardUser("Rodolfo", 1),
                        new CardUser("Rodolfo", 1)
                    });

                    context.SaveChanges();
                }


                //SHops
                //if (!context.Shops.Any())
                //{
                //    context.Shops.AddRange(new List<Shop>()
                //    {
                //        new Shop("Americanas", new DateTime(2022,01,01),"Tv 32 polegadas LG", 999.99,3,
                //    });
                //}
            }
        }
    }
}
