using BelMob.Core.DTOs.Request;
using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Interfaces.Repositorios
{
    public interface IClienteRepository
    {
        bool Criar(Cliente cliente);
        Cliente BuscarPorId(int id);
        List<Cliente> Listar();
        Cliente AlterarDados(CadastroClienteRequest clienteRequest, int id);
        Cliente Deletar(int id);
    }
}
