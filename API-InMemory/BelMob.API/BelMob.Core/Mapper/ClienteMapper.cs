﻿using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Mapper
{
    public static class ClienteMapper
    {
        public static ClienteResponse Converter(this Cliente cliente)
        {
            var dto = new ClienteResponse();
            dto.Id = cliente.Id;
            dto.Nome = cliente.Nome;
            dto.Enderecos = cliente.Enderecos.Select(c => EnderecoMapper.Converter(c)).ToList();
            return dto;
        }
        public static Cliente Converter(this CadastroClienteRequest request)
        {
            var cliente = new Cliente(request.Nome, request.Email, request.Senha);
            var endereco = new Endereco(request.Rua, request.Cep, request.Numero, request.Complemento, Enums.TipoEndereco.Residencial);

            cliente.AdicionarEndereco(endereco);
            return cliente;
        } 
        //public static Cliente Converter(this CadastroClienteRequest request)
        //{
        //    var dto = new Cliente();
        //    dto.Nome = request.Nome;
        //    dto.Email = request.Email;
        //    dto.Senha = request.Senha;

        //    var endereco = new Endereco();
        //    endereco.Rua = request.Rua;
        //    endereco.Cep = request.Cep;
        //    endereco.Numero = request.Numero;
        //    endereco.Complemento = request.Complemento;
        //    endereco.Tipo = request.Tipo;

        //    dto.AdicionarEndereco(endereco);
        //    return dto;
        //}
    }
}
