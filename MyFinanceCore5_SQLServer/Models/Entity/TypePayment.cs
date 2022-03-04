﻿using MyFinanceCore5_SQLServer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.Entity
{
    public class TypePayment:IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string FlagCard { get; set; }


        //Relationship


        //icon

        public int PictureIconId { get; set; }

        public PictureIcon PictureIcon { get; set; }

        //Payment
        public List<Payment> Payments { get; set; }

    }
}