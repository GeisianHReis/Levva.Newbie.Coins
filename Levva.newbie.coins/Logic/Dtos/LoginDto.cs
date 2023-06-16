using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Levva.newbie.coins.Logic.Dtos
{
    public class LoginDto
    {
        public int Id {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public string Name {get; set;}
        public string Token {get; set;}

    }
}