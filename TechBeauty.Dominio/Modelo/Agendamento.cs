using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Agendamento
    {

        public int Id { get; private set; }
        public Servico Servico { get; private set; }
        public Colaborador Colaborador { get; private set; }
        public string PessoaAtendida { get; private set; }
        public OrdemServico OS { get; private set; }
        public DateTime DataHoraInicio { get; private set; }
        public DateTime DataHoraCriacao { get; private set; }
        public DateTime DataHoraTermino { get; private set; }
        public int ServicoID { get; set; }
        public int ColaboradorID { get; set; }
        public int OrdemServicoID { get; set; }
        public List<LogAgendamento> LogsAgendamento { get; set; }

        public static Agendamento Criar(int id, Servico servico, Colaborador colaborador,
            string pessoaAtendida, DateTime dataHoraInicio, OrdemServico os, DateTime dataHoraCriacao,
            DateTime dataHoraTermino)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.Id = id;
            agendamento.Servico = servico;
            agendamento.Colaborador = colaborador;
            agendamento.PessoaAtendida = pessoaAtendida;
            agendamento.DataHoraInicio = dataHoraInicio;
            agendamento.OS = os;
            agendamento.DataHoraCriacao = dataHoraCriacao;
            agendamento.DataHoraTermino = dataHoraTermino;
            return agendamento;
        }

        public void AlterarServico(Servico servico)
        {
            Servico = servico;
        }

        public void AlterarColaborador(Colaborador colaborador)
        {
            Colaborador = colaborador;
        }

        public void AlterarPessoaAtendida(string pessoaAtendida)
        {
            PessoaAtendida = pessoaAtendida;
        }

        public void Remarcar(DateTime dataHoraInicio)
        {
            DataHoraInicio = dataHoraInicio;
        }

    }
}
