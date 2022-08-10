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

        public Profissional Cadastrar(CadastroProfissionalRequest profissionalRequest)
        {
            var profissionais = _profissionalRepository.Listar();
            foreach (var verificar in profissionais)
            {
                if (verificar.CPF == profissionalRequest.CPF)
                {
                    throw new Exception("CPF já existe no banco de dados");
                }
                if (verificar.Email == profissionalRequest.Email)
                {
                    throw new Exception("Email já existe no banco de dados");
                }
            }
            var profissional = ProfissionalMapper.Converter(profissionalRequest);

            _profissionalRepository.Criar(profissional);
            return profissional;
        }
        public List<ProfissionalResponse> Listar()
        {
            var list = _profissionalRepository.Listar();

            return list.Select(c => ProfissionalMapper.Converter(c)).ToList();
        }
        public ProfissionalResponse AlterarDados(int Id, CadastroProfissionalRequest profissionalRequest)
        {
            var result = _profissionalRepository.AlterarDados(Id); 
            result.Nome = profissionalRequest.Nome;
            result.Sobrenome = profissionalRequest.Sobrenome;
            result.Email = profissionalRequest.Email;            
            result.Senha = profissionalRequest.Senha;
            result.Sexo = profissionalRequest.Sexo;
            result.Telefone = profissionalRequest.Telefone;
            result.Celular = profissionalRequest.Celular;
            result.Banco = profissionalRequest.Banco;
            result.Conta = profissionalRequest.Conta;
            result.TipoConta = profissionalRequest.TipoConta;
            result.Agencia = profissionalRequest.Agencia;

            return _profissionalRepository.AlterarDados(Id).Converter();
        }

        public ProfissionalResponse Deletar(int id)
        {
            var result = _profissionalRepository.Deletar(id);
            return ProfissionalMapper.Converter(result);
        }

        public ProfissionalResponse BuscarPorId(int Id)
        {
            var profissional = _profissionalRepository.BuscarPorId(Id).Converter();
            return profissional;
        }
    }
}
