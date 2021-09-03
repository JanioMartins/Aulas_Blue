using BlueDev.Models;
using System.Collections.Generic;
namespace BlueDev.Services
{
    public interface IAlunosService
    {
        bool create(Alunos alunos);
        bool delete(int? id);
        Alunos get(int? id);
        List<Alunos> getAll();
        bool update(Alunos a);
    }
}