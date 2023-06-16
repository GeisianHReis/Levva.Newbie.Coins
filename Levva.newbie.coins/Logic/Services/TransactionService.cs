
using AutoMapper;
using Levva.newbie.coins.Data.Interfaces;
using Levva.newbie.coins.Logic.Dtos;
using Levva.newbie.coins.Logic.Interfaces;
using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Logic.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _repository;
        private readonly IMapper _mapper;

        public TransactionService(ITransactionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Create(TransactionDto Transaction)
        {
            var _Transaction = _mapper.Map<Transaction>(Transaction);
            _Transaction.Date = DateTime.Now;
            _repository.Create(_Transaction);
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public TransactionDto Get(int Id)
        {
            var _Transaction = _mapper.Map<TransactionDto>(_repository.Get(Id));
            return _Transaction;
        }

        public List<TransactionDto> GetAll()
        {
            var Transactions = _mapper.Map<List<TransactionDto>>(_repository.GetAll());
            Transactions.Reverse();
            
            return Transactions;
        }

        public void Update(TransactionDto Transaction)
        {
            var _Transaction = _mapper.Map<Transaction>(Transaction);
            _repository.Update(_Transaction);
        }
    }
}