using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ColaboradorRepositorio
    {
        protected readonly Contexto contexto;

        public ColaboradorRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Colaborador colaborador)
        {
            contexto.Colaborador.Add(colaborador);
            contexto.SaveChanges();
        }

        public void Alterar(Colaborador colaborador)
        {
            contexto.Colaborador.Update(colaborador);
            contexto.SaveChanges();
        }

        public Colaborador SelecionarPorId(int id)
        {
            return contexto.Cliente.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            contexto.Colaborador.Remove(SelecionarPorId(id));
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        /*
        private void PreencherDados(List<Contato> contatos,
            List<Servico> servicos,
            Endereco endereco,
            Genero genero,
            ContratoTrabalho contratoTrabalho)
        {
            Contato c1 = contatos.Where(x => x.Id == 1).FirstOrDefault();
            Contato c2 = contatos.Where(x => x.Id == 2).FirstOrDefault();
            Contato c3 = contatos.Where(x => x.Id == 3).FirstOrDefault();

            List<Contato> contatos1 = new List<Contato>() { c1, c2 };
            List<Contato> contatos2 = new List<Contato>() { c3, c2 };

            Servico s1 = servicos.Where(x => x.Id == 1).FirstOrDefault();
            Servico s2 = servicos.Where(x => x.Id == 2).FirstOrDefault();
            Servico s3 = servicos.Where(x => x.Id == 3).FirstOrDefault();

            List<Servico> servicos1 = new List<Servico>() { s2, s1 };
            List<Servico> servicos2 = new List<Servico>() { s3 };

            TabelaColaborador.Add(Colaborador.Criar(servicos1, endereco, genero,"feminino",
                contratoTrabalho,1, "Geovanna", "542.659.3578.41", new DateTime(1997, 04, 09), contatos1));
            TabelaColaborador.Add(Colaborador.Criar(servicos2, endereco, genero, "feminino",
                contratoTrabalho,2, "Thamyres", "785.496.852.23", new DateTime(1994, 06, 10), contatos2));
        }*/

    }
}
