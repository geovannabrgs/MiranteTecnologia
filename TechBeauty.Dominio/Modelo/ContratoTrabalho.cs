
using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class ContratoTrabalho
    {
        public int Id { get; private set; }
        public int RegimeContratualID { get; set; }
        public RegimeContratual RegimeContratual { get; private set; }
        public DateTime DataEntrada { get; private set; }
        public DateTime? DataDesligamento { get; private set; }
        public int ColaboradorID { get; set; }
        public List<CargoContratoTrabalho> CargosContratosTrabalho { get; set; }
        public string CnpjCTPS { get; private set; }

        public static ContratoTrabalho Criar(int Id, RegimeContratual regimeContratual, DateTime dataEntrada,
            List<CargoContratoTrabalho> cargosContratosTrabalhos, string cnpjCTPS)
        {
            ContratoTrabalho contratoTrabalho = new ContratoTrabalho();
            contratoTrabalho.Id = Id;
            contratoTrabalho.RegimeContratual = regimeContratual;
            contratoTrabalho.DataEntrada = dataEntrada;
            contratoTrabalho.CargosContratosTrabalho = cargosContratosTrabalhos;
            contratoTrabalho.CnpjCTPS = cnpjCTPS;
            return contratoTrabalho;
        }

        public void RenovarContrato(DateTime dataEntrada, DateTime? dataDesligamento = null)
        {
            DataEntrada = dataEntrada;
            DataDesligamento = dataDesligamento;
        }

        public void AlterarCnpjCTPS(string cnpjCTPS)
        {
            CnpjCTPS = cnpjCTPS;
        }

        public void AlterarRegimeContratual(RegimeContratual regimeContratual)
        {
            RegimeContratual = regimeContratual;
        }

        public void AddCargo(CargoContratoTrabalho cargosContratoTrabalho)
        {
            CargosContratosTrabalho.Add(cargosContratoTrabalho);
        }

        public void RemoverCargo(CargoContratoTrabalho cargosContratoTrabalho)
        {
            CargosContratosTrabalho.Remove(cargosContratoTrabalho);
        }

        public void AddDataDesligamento(DateTime data)
        {
            DataDesligamento = data;
        }

    }
}