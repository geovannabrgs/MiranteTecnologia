using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class Pagamento : IEntity
    {
        public int Id { get; private set; }
        public decimal ValorPagamento;
        public decimal FechamentoDia { get; set; }
        public decimal Caixa { get; set; }
        public Cliente cliente { get; set; }


        public static Pagamento Criar(int id, decimal pagamento, decimal fechamentoDia, decimal caixa, Cliente cliente)
        {
            Pagamento pagamentoCliente = new Pagamento();
            pagamentoCliente.Id = id;
            pagamentoCliente.ValorPagamento = pagamento;
            pagamentoCliente.FechamentoDia = fechamentoDia;
            pagamentoCliente.Caixa = caixa;
            pagamentoCliente.cliente = cliente;

            return pagamentoCliente;
        }

        public void Alterar(int id, decimal pagamento)
        {
            Id = id;
            ValorPagamento = pagamento;
        }
    }
}
