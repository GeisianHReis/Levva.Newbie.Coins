
using AutoMapper;
using Levva.newbie.coins.Data.Interfaces;
using Levva.newbie.coins.Logic.Dtos;
using Levva.newbie.coins.Logic.Interfaces;
using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Logic.Services
{
    public class TransacaoService : ITransacaoService
    {
        private readonly ITransacaoRepository _repository;
        private readonly IMapper _mapper;

        public TransacaoService(ITransacaoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Create(TransacaoDto transacao)
        {
            var _transacao = _mapper.Map<Transacao>(transacao);
            _transacao.Data = DateTime.Now;
            _repository.Create(_transacao);
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public TransacaoDto Get(int Id)
        {
            var _transacao = _mapper.Map<TransacaoDto>(_repository.Get(Id));
            return _transacao;
        }

        public List<TransacaoDto> GetAll()
        {
            var transacoes = _mapper.Map<List<TransacaoDto>>(_repository.GetAll());
            transacoes.Reverse();
            
            return transacoes;
        }

        public void Update(TransacaoDto transacao)
        {
            var _transacao = _mapper.Map<Transacao>(transacao);
            _repository.Update(_transacao);
        }
    }
}