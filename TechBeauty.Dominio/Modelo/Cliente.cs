
using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Cliente : Pessoa
    {

        public List<OrdemServico> OrdensServico { get; set; }

        public static Cliente Criar(int id, string nome, string cpf, DateTime dataNascimento, List<Contato> contatos)
        {
            Cliente cliente = new Cliente();
            cliente.Id = id;
            cliente.Nome = nome;
            cliente.CPF = cpf;
            cliente.DataNascimento = dataNascimento;
            cliente.Contatos = contatos;
            return cliente;
        }

        public void AlterarNomeCliente(string nome, string cpf)
        {
            Nome = nome;
        }

        public void AlterarContatosCliente(string nome, string cpf, List<Contato> contatos)
        {
            Contatos = contatos;
        }
    }
}
