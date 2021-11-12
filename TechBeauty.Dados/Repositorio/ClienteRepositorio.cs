using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ClienteRepositorio
    {
        protected readonly Contexto contexto;

        public ClienteRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Cliente cliente)
        {
            contexto.Cliente.Add(cliente);
            contexto.SaveChanges();
        }

        public void AlterarNomeCliente(Cliente cliente)
        {
            contexto.Cliente.Update(cliente);
            contexto.SaveChanges();
        }

        public void AlterarContatosCliente(Cliente cliente)
        {
            contexto.Cliente.Update(cliente);
            contexto.SaveChanges();
        }

        public Cliente SelecionarPorId(int id)
        {
            return contexto.Cliente.FirstOrDefault(x => x.Id == id); 
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Cliente.Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        /*
        private void PreencherDados(List<Contato> contatos)
        {
            var con1 = contatos.Where(x => x.Id == 1).FirstOrDefault();
            var con2 = contatos.Where(x => x.Id == 2).FirstOrDefault();
            var con3 = contatos.Where(x => x.Id == 3).FirstOrDefault();

            List<Contato> contatos1 = new List<Contato>() { con1, con2 };
            List<Contato> contatos2 = new List<Contato>() { con2, con3 };
            List<Contato> contatos3 = new List<Contato>() { con1, con3 };

            TabelaCliente.Add(Cliente.Criar(1, "Geovanna", "485.457.695.82", new DateTime(1997, 04, 09), contatos1));
            TabelaCliente.Add(Cliente.Criar(1, "Thamyres", "853.659.124.52", new DateTime(1994, 03, 10), contatos2));
            TabelaCliente.Add(Cliente.Criar(1, "Cleber", "859.653.265.41", new DateTime(2000, 02, 03), contatos3));
        }*/


    }

}