using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Modelo.Enumerados;

namespace TechBeauty.Dados.Repositorio
{
    public class OrdemServicoRepositorio
    {

        public List<OrdemServico> TabelaOrdemServico { get; private set; } = new List<OrdemServico>();

        public OrdemServicoRepositorio(Cliente cliente)
        {
            PreencherDados(cliente);
        }

        public void Incluir(OrdemServico ordemServico)
        {
            TabelaOrdemServico.Add(ordemServico);
        }

        public void AlterarStatus(int id, StatusOS status)
        {
            TabelaOrdemServico.FirstOrDefault(x => x.Id == id).AlterarStatus(status);
        }
        public void AlterarCliente(int id, Cliente cliente)
        {
            TabelaOrdemServico.FirstOrDefault(x => x.Id == id).AlterarCliente(cliente);
        }

        public OrdemServico SelecionarPorId(int id)
        {
            return TabelaOrdemServico.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaOrdemServico.Remove(SelecionarPorId(id));
        }

        private void PreencherDados(Cliente cliente)
        {
            TabelaOrdemServico.Add(OrdemServico.Criar(1, 100.00m, 30, cliente, StatusOS.Pendente));
            TabelaOrdemServico.Add(OrdemServico.Criar(2, 140.00m, 30, cliente, StatusOS.Concluido));
            TabelaOrdemServico.Add(OrdemServico.Criar(3, 30.00m, 30, cliente, StatusOS.ParcialmenteConcluido));
            TabelaOrdemServico.Add(OrdemServico.Criar(4, 50.50m, 30, cliente, StatusOS.Cancelado));
        }


    }
}
