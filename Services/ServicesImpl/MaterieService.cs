using OrarUniversitar.Services;
using System.Collections.Generic;
using System.Linq;

namespace OrarUniversitar.Services
{
    public class MaterieService : IMaterieService
    {
        private readonly List<Materie> materii = new List<Materie>();

        public void AdaugaMaterie(Materie materie)
        {
            materii.Add(materie);
        }

        public void StergeMaterie(int id)
        {
            materii.RemoveAll(m => m.Id == id);
        }

        public Materie CautaMaterie(int id)
        {
            return materii.FirstOrDefault(m => m.Id == id);
        }

        public List<Materie> ObtineMaterii()
        {
            return materii;
        }
    }
}
