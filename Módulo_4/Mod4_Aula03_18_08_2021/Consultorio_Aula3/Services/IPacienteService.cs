using Consultorio.Models;
using System.Collections.Generic;

namespace Consultorio.Services
{
    // Responsável por generalizar as ações dos meus serviços
    public interface IPacienteService
    {
        bool create(Paciente paciente);
        bool delete(int? id);
        Paciente get(int? id);
        List<Paciente> getAll(string busca = null, bool ord = false);
        bool update(Paciente p);
    }
}