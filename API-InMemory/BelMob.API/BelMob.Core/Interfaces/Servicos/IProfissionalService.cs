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
        Profissional BuscarPorId(int Id);
        List<ProfissionalResponse> Listar(); 
        Profissional AlterarDados(int Id, CadastroProfissionalRequest profissional);
        Profissional Deletar(int id);
    }
}
