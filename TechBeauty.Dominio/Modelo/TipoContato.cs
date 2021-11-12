using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class TipoContato
    {
        public int Id { get; private set; }
        public string Valor { get; private set; }
        public List<Contato> Contatos { get; set; }

        public static TipoContato Criar(int id, string valor)
        {
            TipoContato tipoContato = new TipoContato();
            tipoContato.Id = id;
            tipoContato.Valor = valor;
            return tipoContato;
        }

        public void AlterarValor(string valor)
        {
            Valor = valor;
        }

    }
}