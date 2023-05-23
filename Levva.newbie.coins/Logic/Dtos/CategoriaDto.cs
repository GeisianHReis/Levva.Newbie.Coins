
namespace Levva.newbie.coins.Logic.Dtos
{
    public class CategoriaDto
    {
        public int Id{get; set;}
        public string Descricao{get; set;}
        public int TransacaoId{get; set;}
        public List<TransacaoDto> Transacoes{get; set;}
    }
}