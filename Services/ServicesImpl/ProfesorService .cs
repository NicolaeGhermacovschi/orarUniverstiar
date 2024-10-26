using OrarUniversitar.Services;
using System.Collections.Generic;
using System.Linq;

namespace OrarUniversitar.Services
{
    public class ProfesorService : IProfesorService
    {
        private readonly List<Profesor> profesori = new List<Profesor>();

        public void AdaugaProfesor(Profesor profesor)
        {
            profesori.Add(profesor);
        }

        public void StergeProfesor(int id)
        {
            profesori.RemoveAll(p => p.Id == id);
        }

        public Profesor CautaProfesor(int id)
        {
            return profesori.FirstOrDefault(p => p.Id == id);
        }

        public List<Profesor> ObtineProfesori()
        {
            return profesori;
        }
    }
}
