using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Enumeradores;
using System.Linq;

namespace TechBeauty.Dados.Repositorio
{
    public class LogAgendamentoRepositorio
    {

        public List<LogAgendamento> TabelaLogAgendamento { get; private set; } = new List<LogAgendamento>();

        public LogAgendamentoRepositorio(StatusAgendamento status)
        {
            PreencherDados(status);
        }

        public void Incluir(LogAgendamento logAgendamento)
        {
            TabelaLogAgendamento.Add(logAgendamento);
        }

        public void Alterar(int AgendamentoID, StatusAgendamento status)
        {
            TabelaLogAgendamento.FirstOrDefault(x => x.AgendamentoID == AgendamentoID).AlterarStatus(status);
        }

        public LogAgendamento SelecionarPorId(int AgendamentoID)
        {
            return TabelaLogAgendamento.FirstOrDefault(x => x.AgendamentoID == AgendamentoID);
        }

        public void Excluir(int AgendamentoID)
        {
            TabelaLogAgendamento.Remove(SelecionarPorId(AgendamentoID));
        }

        private void PreencherDados(StatusAgendamento status)
        {
            TabelaLogAgendamento.Add(LogAgendamento.Criar(new DateTime(2021, 10, 22), status));
            TabelaLogAgendamento.Add(LogAgendamento.Criar(new DateTime(2021, 10, 20), status));
            TabelaLogAgendamento.Add(LogAgendamento.Criar(new DateTime(2021, 10, 10), status));
        }
    }
}