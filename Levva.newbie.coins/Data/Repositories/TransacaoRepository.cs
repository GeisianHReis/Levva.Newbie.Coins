using Levva.newbie.coins.Data.Interfaces;
using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Data.Repositories
{
    public class TransacaoRepository : ITransacaoRepository
    {
        private readonly Context _context;
        public TransacaoRepository(Context context){
            _context = context;
        }
        public void Create(Transacao transacao)
        {
            _context.Transacao.Add(transacao);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var transacao = _context.Transacao.Find(Id);
            _context.Transacao.Remove(transacao);
            _context.SaveChanges();
        }

        public Transacao Get(int Id)
        {
            var transacao = _context.Transacao.Find(Id);
            return transacao;
        }

        public List<Transacao> GetAll()
        {
            var transacoes = _context.Transacao.ToList();
            return transacoes;
        }

        public void Update(Transacao transacao)
        {
            _context.Transacao.Update(transacao);
            _context.SaveChanges();
        }
    }
}