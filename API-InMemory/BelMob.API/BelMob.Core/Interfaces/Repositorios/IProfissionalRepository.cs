using BelMob.Core.DTOs.Request;
using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Interfaces.Repositorios
{
    public interface IProfissionalRepository
    {
        Profissional Criar(Profissional profissional);
        Profissional BuscarPorId(int id);
        List<Profissional> Listar();
        Profissional AlterarDados(int id);
        Profissional Deletar(int id);
    }
}
