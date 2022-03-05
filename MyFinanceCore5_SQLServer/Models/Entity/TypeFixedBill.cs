﻿using MyFinanceCore5_SQLServer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.Entity
{
    public class TypeFixedBill : IBaseEntity
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage ="Campo {0} é obrigatório")]
        public string Name { get; set; }





        public TypeFixedBill() { }
        public TypeFixedBill( string name)
        {
           
            Name = name;
        }


        //Relationship
        public List<FixedBill> FixedBills { get; set; }

    }
}
