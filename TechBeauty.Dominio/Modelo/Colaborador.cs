
using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Colaborador : Pessoa
    {
        public List<Servico> Servicos { get; private set; }
        public Endereco Endereco { get; private set; }
        public Genero Genero { get; private set; }
        public string NomeSocial { get; private set; }
        public ContratoTrabalho ContratoTrabalho { get; private set; }
        public int EnderecoID { get; set; }
        public int GeneroID { get; set; }
        public List<Escala> Escalas { get; set; }
        public int ContratoTrabalhoID { get; set; }
        public List<ServicoColaborador> ServicosColaborador { get; set; }
        public List<Agendamento> Agendamentos { get; set; }

        public static Colaborador Criar(List<Servico> servicos,Endereco endereco,Genero genero,string nomeSocial,
            ContratoTrabalho contratoTrabalho,int id,string nome,string cpf,DateTime dataNascimento,List<Contato> contatos)
        {
            Colaborador colaborador = new Colaborador();
            colaborador.Id = id;
            colaborador.Servicos = servicos;
            colaborador.Endereco = endereco;
            colaborador.Genero = genero;
            colaborador.NomeSocial = nomeSocial;
            colaborador.ContratoTrabalho = contratoTrabalho;
            colaborador.Nome = nome;
            colaborador.CPF = cpf;
            colaborador.DataNascimento = dataNascimento;
            colaborador.Contatos = contatos;

            return colaborador;
        }

        public void AddServico(Servico servico)
        {
            Servicos.Add(servico);
        }

        public void RemoveServico(Servico servico)
        {
            Servicos.Remove(servico);
        }

        public void AlterarNomeSocial(string nomeSocial)
        {
            NomeSocial = nomeSocial;
        }


    }
}