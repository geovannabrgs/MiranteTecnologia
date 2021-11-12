
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Endereco
    {
        public int Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string CEP { get; private set; }
        public string Bairro { get; private set; }
        public List<Colaborador> Colaboradores { get; set; }

        public static Endereco Criar(int id, string logradouro, string cidade,
            string uf, string numero, string cep, string bairro, string complemento = "")
        {
            Endereco endereco = new Endereco();
            endereco.Id = id;
            endereco.Logradouro = logradouro;
            endereco.Cidade = cidade;
            endereco.UF = uf;
            endereco.Numero = numero;
            endereco.CEP = cep;
            endereco.Bairro = bairro;
            endereco.Complemento = complemento;
            return endereco;
        }

        public void MudarEndereco(string uf, string cep, string cidade, string logradouro, string numero, string bairro, string complemento = "")
        {
            UF = uf;
            CEP = cep;
            Cidade = cidade;
            Logradouro = logradouro;
            Bairro = bairro;
            Numero = numero;
            Complemento = complemento;
        }
    }

}
