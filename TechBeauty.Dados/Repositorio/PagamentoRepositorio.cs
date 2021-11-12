using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class PagamentoRepositorio 
    {
        protected readonly Contexto contexto;

        public PagamentoRepositorio()
        {
            contexto = new Contexto();
        }
        public void Incluir(Pagamento pagamento)
        {
            contexto.Pagamento.Add(pagamento);
            contexto.SaveChanges();
        }
        public void Alterar(Pagamento pagamento)
        {
            contexto.Pagamento.Update(pagamento);
            contexto.SaveChanges();
        }
        public Contato SelecionarPorId(int id)
        {
            return contexto.Pagamento.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Pagamento.Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
