namespace TechBeauty.Dominio.Modelo
{
    public class ServicoColaborador
    {
        public int ColaboradorID { get; set; }
        public int ServicoID { get; set; }
        public Servico Servico { get; set; }
        public Colaborador Colaborador { get; set; }

    }
}
