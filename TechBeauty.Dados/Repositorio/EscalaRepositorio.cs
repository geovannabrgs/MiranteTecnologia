using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class EscalaRepositorio
    {
        protected readonly Contexto contexto;

        public EscalaRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Escala escala)
        {
            contexto.Escala.Add(escala);
            contexto.SaveChanges();
        }

        public void AlterarDataHora(Escala escala)
        {
            contexto.Escala.Update(escala);
            contexto.SaveChanges();
        }

        public Escala SelecionarPorId(int id)
        {
            return contexto.Escala.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Escala.Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        /*
        private void PreencherDados(Colaborador colaborador)
        {
            TabelaEscala.Add(Escala.Criar(1, new DateTime(2021, 10, 22, 8, 2, 10), new DateTime(2021, 10, 22, 20, 2, 12), colaborador));
            TabelaEscala.Add(Escala.Criar(2, new DateTime(2021, 10, 22, 8, 2, 10), new DateTime(2021, 10, 22, 20, 2, 12), colaborador));
            TabelaEscala.Add(Escala.Criar(3, new DateTime(2021, 10, 22, 8, 2, 10), new DateTime(2021, 10, 22, 20, 2, 12), colaborador));
        }*/


    }
}
