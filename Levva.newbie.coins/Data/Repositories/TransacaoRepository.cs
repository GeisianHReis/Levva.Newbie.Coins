using Levva.newbie.coins.Data.Interfaces;
using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Data.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly Context _context;
        public TransactionRepository(Context context){
            _context = context;
        }
        public void Create(Transaction Transaction)
        {
            _context.Transaction.Add(Transaction);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var Transaction = _context.Transaction.Find(Id);
            _context.Transaction.Remove(Transaction);
            _context.SaveChanges();
        }

        public Transaction Get(int Id)
        {
            var Transaction = _context.Transaction.Find(Id);
            return Transaction;
        }

        public List<Transaction> GetAll()
        {
            var Transactions = _context.Transaction.ToList();
            return Transactions;
        }

        public void Update(Transaction Transaction)
        {
            _context.Transaction.Update(Transaction);
            _context.SaveChanges();
        }
    }
}