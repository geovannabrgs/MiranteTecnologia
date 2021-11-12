using System.Collections.Generic;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Modelo.Enumerados;

namespace TechBeauty.Dominio.Modelo
{
    public class OrdemServico
    {
        public int Id { get; private set; }
        public decimal PrecoTotal { get; private set; }
        public int DuracaoTotal { get; private set; }
        public Cliente Cliente { get; private set; }
        public StatusOS Status { get; private set; }
        public int ClienteID { get; set; }
        public List<Agendamento> Agendamentos { get; set; }

        public static OrdemServico Criar(int id, decimal precoTotal, int duracaoTotal, Cliente cliente, StatusOS status)
        {
            OrdemServico ordemServico = new OrdemServico();
            ordemServico.Id = id;
            ordemServico.PrecoTotal = precoTotal;
            ordemServico.DuracaoTotal = duracaoTotal;
            ordemServico.Cliente = cliente;
            ordemServico.Status = status;
            return ordemServico;
        }

        public void AddValorPrecoTotal(decimal preco)
        {
            PrecoTotal += preco;
        }

        public void RemoveValorPrecoTotal(decimal preco)
        {
            PrecoTotal -= preco;
        }

        public void AddDuracaoTotal(int tempoEmMin)
        {
            DuracaoTotal += tempoEmMin;
        }

        public void RemoverDuracaoTotal(int tempoEmMin)
        {
            DuracaoTotal += tempoEmMin;
        }

        public void AlterarCliente(Cliente cliente)
        {
            Cliente = cliente;
        }

        public void AlterarStatus(StatusOS status)
        {
            Status = status;
        }

    }

}