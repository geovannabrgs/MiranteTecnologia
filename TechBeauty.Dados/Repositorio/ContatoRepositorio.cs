using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ContatoRepositorio
    {
        protected readonly Contexto contexto;


        public ContatoRepositorio(List<TipoContato> tiposContato)
        {
            contexto = new Contexto();
        }

        public void Incluir(Contato contato)
        {
            contexto.Contato.Add(contato);
            contexto.SaveChanges();
        }

        public void Alterar(Contato contato)
        {
            contexto.Contato.Update(contato);
            contexto.SaveChanges();
        }

        public Contato SelecionarPorId(int id)
        {
            return contexto.Contato.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Contato.Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        /*
        private void PreencherDados(List<TipoContato> tiposContato)
        {
            var tipoContato1 = tiposContato.Where(x => x.Id == 1).FirstOrDefault();
            Incluir(Contato.Criar(1, tipoContato1, "1198864455"));

            var tipoContato2 = tiposContato.Where(x => x.Id == 2).FirstOrDefault();
            Incluir(Contato.Criar(2, tipoContato2, "@thamirysGameiro"));

            var tipoContato3 = tiposContato.FirstOrDefault(x => x.Id == 3);
            Incluir(Contato.Criar(3, tipoContato3, "@thamirysGameiro"));
        }*/


    }
}