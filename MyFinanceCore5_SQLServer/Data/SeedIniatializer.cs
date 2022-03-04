﻿using Microsoft.AspNetCore.Builder;
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
            using(var serviceScope = applicationsBuilder.ApplicationServices.CreateScope())
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
            }
        }
    }
}