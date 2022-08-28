using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Interfaces.Servicos
{
    public interface IProfissionalService
    {
        ProfissionalResponse Cadastrar(CadastroProfissionalRequest profissional);
        ProfissionalResponse BuscarPorId(int Id);
        List<ProfissionalResponse> Listar();
        ProfissionalResponse AlterarDados(int Id, CadastroProfissionalRequest profissional);
        ProfissionalResponse Deletar(int id);
        public int LoginProfissional(string email, string senha);
    }
}
