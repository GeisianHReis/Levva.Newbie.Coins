using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Levva.newbie.coins.Domain.Enuns;

namespace Levva.newbie.coins.Domain.Models
{
    public class Transacao
    {
        public int Id{get; set;}
        public string Descricao{get; set;}
        public decimal Valor{get; set;}
        public DateTime Data{get; set;}
        public TipoTransacao Tipo{get; set;}
        public int CategoriaId{get; set;}
        public virtual Categoria Categoria{get; set;}
        public int UsuarioId{get; set;}
        public virtual Usuario Usuario{get; set;}

    }
}