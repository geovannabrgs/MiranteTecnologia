using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    class ServicoRepositorio
    {
        protected readonly Contexto contexto;

        public ServicoRepositorio()
        {
            contexto = new Contexto();
        }
        public void Incluir(Servico servico)
        {
            contexto.Servico.Add(servico);
            contexto.SaveChanges();
        }

        public void AlterarNome(string nome, Servico servico)
        {
            contexto.Servico.Update(servico);
            contexto.SaveChanges();
        }

        public void AlterarPreco(int id, decimal preco, Servico servico)
        {
            contexto.Servico.Update(servico);
            contexto.SaveChanges();
        }

        public void AlterarDescricao(int id, string descricao, Servico servico)
        {
            contexto.Servico.FirstOrDefault(x => x.Id == id).AlterarDescricao(descricao);
        }

        public void AlterarDuracaoEmMin(int id, int duracaoEmMin, Servico servico)
        {
            contexto.Servico.FirstOrDefault(x => x.Id == id).AlterarDuracaoEmMin(duracaoEmMin);
        }

        public Servico SelecionarPorId(int id)
        {
            return contexto.Servico.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Servico.Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        /*
        private void PreencherDados()
        {
            TabelaServico.Add(Servico.Criar(1, "Corte de cabelo longo", 50m, "Cortar cabelo", 20));

            TabelaServico.Add(Servico.Criar(2, "Corte de cabelo curto", 35m, "Cortar cabelo", 20));

            TabelaServico.Add(Servico.Criar(3, "Manicure", 25m, "Cutilagem e pintura das unhas", 40));

            TabelaServico.Add(Servico.Criar(4, "Depilação de pernas", 40m, "Depilação das pernas", 40));

            TabelaServico.Add(Servico.Criar(5, "Depilação das axilas", 25m, "Depilação das pernas", 15));

            TabelaServico.Add(Servico.Criar(6, "Pintar cabelo", 30m, "Pintar a cor do cabelo", 40));
        }*/

    }
}

