
using Levva.newbie.coins.Logic.Dtos;

namespace Levva.newbie.coins.Logic.Interfaces
{
    public interface ITransacaoService
    {
        void Create(TransacaoDto transacao);
        void Update(TransacaoDto transacao);
        List<TransacaoDto> GetAll();
        TransacaoDto Get(int Id);
        void Delete(int Id);
    }
}