
namespace Levva.newbie.coins.Logic.Dtos
{
    public class UsuarioDto
    {
        
        public int Id{get; set;}
        public string Nome{get; set;}
        public string Email{get; set;}
        public string Senha{get; set;}
        public List<TransacaoDto> Transacoes{get; set;}
    }
}