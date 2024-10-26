using OrarUniversitar.Services;
using System.Collections.Generic;

namespace OrarUniversitar.Services
{
    public interface IOrarService
    {
        void AdaugaOrar(Orar orar);
        void StergeOrar(int id);
        Orar CautaOrar(int id);
        List<Orar> ObtineOre();
    }
}
