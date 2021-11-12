using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class CargoRepositorio : RepositorioBase<Cargo>
    {
        public bool ConsultaPorNome(string nome)
        {
            return contexto.Cargo.Any(x => x.Nome == nome);
        }
        public override void Incluir(Cargo entity)
        {
            if (!ConsultaPorNome(entity.Nome))
                base.Incluir(entity);
        }
    }
}
