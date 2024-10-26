using OrarUniversitar.Services;
using System.Collections.Generic;

namespace OrarUniversitar.Services
{
    public interface IMaterieService
    {
        void AdaugaMaterie(Materie materie);
        void StergeMaterie(int id);
        Materie CautaMaterie(int id);
        List<Materie> ObtineMaterii();
    }
}
