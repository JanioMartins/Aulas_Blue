using BlueDev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDev.Services
{
    public class ILinguagensService
    {

        bool create(Linguagens l);
        bool delete(int id);
        Linguagens get(int id);
        List<Linguagens> getAll(string busca = null, bool ord = false);
        bool update(Linguagens lin);

    }
}
