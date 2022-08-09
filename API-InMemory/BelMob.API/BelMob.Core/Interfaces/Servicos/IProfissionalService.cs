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
        void Cadastrar(CadastroProfissionalRequest profissional);
        Usuario BuscarPorId(int Id);
        List<ProfissionalResponse> Listar();
        Usuario AlterarDados(int Id, CadastroProfissionalRequest profissional);
        Usuario Deletar(int id);
    }
}
