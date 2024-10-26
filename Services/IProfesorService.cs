using OrarUniversitar.Services;
using System.Collections.Generic;

namespace OrarUniversitar.Services
{
    public interface IProfesorService
    {
        void AdaugaProfesor(Profesor profesor);
        void StergeProfesor(int id);
        Profesor CautaProfesor(int id);
        List<Profesor> ObtineProfesori();
    }
}
