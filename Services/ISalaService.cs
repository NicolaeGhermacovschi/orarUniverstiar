using OrarUniversitar.Services;
using System.Collections.Generic;

namespace OrarUniversitar.Services
{
    public interface ISalaService
    {
        void AdaugaSala(Sala sala);
        void StergeSala(int id);
        Sala CautaSala(int id);
        List<Sala> ObtineSali();
    }
}
