using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class EnderecoRepositorio
    {

        public List<Endereco> TabelaEndereco { get; private set; } = new List<Endereco>();

        public EnderecoRepositorio()
        {
            PreencherDados();
        }

        public void Incluir(Endereco endereco)
        {
            TabelaEndereco.Add(endereco);
        }

        public void Alterar(int id, string uf, string cep, string cidade, string logradouro, string numero, string bairro, string complemento = "")
        {
            TabelaEndereco.FirstOrDefault(x => x.Id == id).MudarEndereco(uf, cep, cidade, logradouro, numero, bairro, complemento);
        }

        public Endereco SelecionarPorId(int id)
        {
            return TabelaEndereco.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaEndereco.Remove(SelecionarPorId(id));
        }

        private void PreencherDados()
        {
            TabelaEndereco.Add(Endereco.Criar(1, " ", "Ceilândia", "DF", "12","72230405", "A", "rua 111"));
            TabelaEndereco.Add(Endereco.Criar(2, " ", "Taguatinga", "DF", "13", "72230404", "B", "chácara 22"));
            TabelaEndereco.Add(Endereco.Criar(3, " ", "Guará", "DF", "14", "72230406", "C"));
            TabelaEndereco.Add(Endereco.Criar(4, " ", "Riacho Fundo II", "DF", "72230407", "15", "D"));
        }

    }
}
