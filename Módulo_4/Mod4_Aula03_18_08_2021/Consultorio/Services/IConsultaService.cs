using Consultorio.Models;
using System.Collections.Generic;

namespace Consultorio.Services
{
    public interface IConsultaService
    {
        bool create(Consulta consulta);
        bool delete(int? id);
        Consulta get(int? id);
        List<Consulta> getAll();
        bool update(Consulta p);
    }
}