using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Data.Interfaces
{
    public interface ITransacaoRepository
    {
        void Create(Transacao transacao);
        void Update(Transacao transacao);
        void Delete(int Id);
        Transacao Get(int Id);
        List<Transacao> GetAll();
    }
}