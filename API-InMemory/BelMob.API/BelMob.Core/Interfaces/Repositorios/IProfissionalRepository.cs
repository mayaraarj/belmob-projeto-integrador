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
        void Criar(Usuario usuario);

        Usuario BuscarPorId(int id);

        List<Usuario> Listar();
        Usuario AlterarDados(int id);
        Usuario Deletar(int id);
    }
}
