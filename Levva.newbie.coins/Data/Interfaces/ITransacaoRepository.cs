using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Data.Interfaces
{
    public interface ITransactionRepository
    {
        void Create(Transaction Transaction);
        void Update(Transaction Transaction);
        void Delete(int Id);
        Transaction Get(int Id);
        List<Transaction> GetAll();
    }
}