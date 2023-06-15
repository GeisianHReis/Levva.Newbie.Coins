using Levva.newbie.coins.Domain.Enuns;
namespace Levva.newbie.coins.Logic.Dtos
{
    public class TransacaoDto
    {
        public int Id{get; set;}
        public string Descricao{get; set;}
        public decimal Valor{get; set;}
        public DateTime Data{get; set;}
        public TipoTransacao Tipo{get; set;}
        public int CategoriaId{get; set;}
        public virtual CategoriaDto Categoria{get; set;}
        public int UsuarioId{get; set;}
    }
}