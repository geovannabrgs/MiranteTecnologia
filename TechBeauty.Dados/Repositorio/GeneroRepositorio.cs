using System.Collections.Generic;
using TechBeauty.Dominio.Modelo;
using System.Linq;

namespace TechBeauty.Dados.Repositorio
{
    public class GeneroRepositorio
    {

        public List<Genero> TabelaGenero { get; private set; } = new List<Genero>();

        public GeneroRepositorio()
        {
            PreencherDados();
        }


        public void Incluir(Genero genero)
        {
            TabelaGenero.Add(genero);
        }

        public void Alterar(int id, string valor)
        {
            TabelaGenero.FirstOrDefault(x => x.Id == id).AlterarValor(valor);
        }

        public Genero SelecionarPorId(int id)
        {
            return TabelaGenero.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaGenero.Remove(SelecionarPorId(id));
        }

        private void PreencherDados()
        {
            Genero genero1 = Genero.Criar(1, "Feminino");
            Incluir(genero1);

            Genero genero2 = Genero.Criar(2, "Masculino");
            Incluir(genero2);

            Genero genero3 = Genero.Criar(3, "Mulher Trans");
            Incluir(genero3);
            
            Genero genero4 = Genero.Criar(4, "Homem Trans");
            Incluir(genero4);

            Genero genero5 = Genero.Criar(5, "Não Binário");
            Incluir(genero5);
        }

    }
}