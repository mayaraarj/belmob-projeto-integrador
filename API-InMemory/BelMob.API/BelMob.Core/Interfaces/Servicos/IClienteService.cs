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
    public interface IClienteService
    {
        ClienteResponse Cadastrar(CadastroClienteRequest cliente);
        ClienteResponse BuscarPorId(int Id);
        ClienteResponse AlterarDados(int Id, int IdEndereco, CadastroClienteRequest cliente);
        List<ClienteResponse> Listar();
        ClienteResponse Deletar(int id);
        public int LoginCliente(string email, string senha);
    }
}

