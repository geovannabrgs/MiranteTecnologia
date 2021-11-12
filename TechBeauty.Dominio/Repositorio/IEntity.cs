using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public interface IEntity
    {
        int Id { get; }
        Cliente cliente { get; set; }
    }
}
