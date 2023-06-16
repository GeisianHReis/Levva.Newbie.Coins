
using Levva.newbie.coins.Logic.Dtos;

namespace Levva.newbie.coins.Logic.Interfaces
{
    public interface ITransactionService
    {
        void Create(TransactionDto Transaction);
        void Update(TransactionDto Transaction);
        List<TransactionDto> GetAll();
        TransactionDto Get(int Id);
        void Delete(int Id);
    }
}