﻿using BelMob.Core.DTOs.Request;
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
        bool Cadastrar(CadastroClienteRequest cliente);
        Cliente BuscarPorId(int Id);
        Cliente AlterarDados(int Id, CadastroClienteRequest cliente);
        List<ClienteResponse> Listar();
        Cliente Deletar(int id);
    }
}
