using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Levva.newbie.coins.Domain.Enuns;

namespace Levva.newbie.coins.Domain.Models
{
    public class Transaction
    {
        public int Id{get; set;}
        public string Description{get; set;}
        public decimal Amount{get; set;}
        public DateTime Date{get; set;}
        public TypeTransaction Type{get; set;}
        public int CategoryId{get; set;}
        public virtual Category Category{get; set;}
        public int UserId{get; set;}
        public virtual User User{get; set;}

    }
}