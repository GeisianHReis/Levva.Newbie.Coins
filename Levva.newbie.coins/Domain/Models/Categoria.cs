namespace Levva.newbie.coins.Domain.Models
{
    public class Categoria
    {
        public int Id{get; set;}
        public string Descricao{get; set;}
        public int TransacaoId{get; set;}
        public List<Transacao> Transacoes{get; set;}

    }
}