using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using BelMob.Core.Interfaces.Repositorios;
using BelMob.Core.Interfaces.Servicos;
using BelMob.Core.Mapper;

namespace BelMob.Core.Servicos
{
    public class ProfissionalService : IProfissionalService 
    {
        private IProfissionalRepository _profissionalRepository;

        public ProfissionalService(IProfissionalRepository profissionalRepository)
        {
            _profissionalRepository = profissionalRepository;
        }

        public void Cadastrar(CadastroProfissionalRequest profissional)
        {
            var user = ProfissionalMapper.Converter(profissional);

            _profissionalRepository.Criar(user);
        }
        public Profissional BuscarPorId(int Id)
        {
            return _profissionalRepository.BuscarPorId(Id);

        }
        public List<ProfissionalResponse> Listar()
        {
            var list = _profissionalRepository.Listar();

            return list.Select(c => ProfissionalMapper.Converter(c)).ToList();
        }
        public Profissional AlterarDados(int Id, CadastroProfissionalRequest profissionalRequest)
        {
            var result = _profissionalRepository.AlterarDados(Id); 
            result.Nome = profissionalRequest.Nome;
            result.Email = profissionalRequest.Email;
            result.Senha = profissionalRequest.Senha;
            result.Banco = profissionalRequest.Banco;
            result.Conta = profissionalRequest.Conta;
            result.TipoDeConta = profissionalRequest.TipoDeConta;
            result.Agencia = profissionalRequest.Agencia;
            return _profissionalRepository.AlterarDados(Id);
        }

        public Profissional Deletar(int id)
        {
            return _profissionalRepository.Deletar(id);
        }
    }
}
