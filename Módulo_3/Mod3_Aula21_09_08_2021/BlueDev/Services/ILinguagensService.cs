
using BlueDev.Models;
using System.Collections.Generic;

namespace BlueDev.Services
{
    // Responsável por generalizar as ações dos meus serviços
    public interface ILinguagensService
    {
        bool create(Linguagens linguagens);
        bool delete(int? id);
        Linguagens get(int? id);
        List<Linguagens> getAll(string busca = null, bool ord = false);
        bool update(Linguagens l);
    }
}