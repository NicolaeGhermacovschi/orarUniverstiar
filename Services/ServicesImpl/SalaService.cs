using OrarUniversitar.Services;
using System.Collections.Generic;
using System.Linq;

namespace OrarUniversitar.Services
{
    public class SalaService : ISalaService
    {
        private readonly List<Sala> sali = new List<Sala>();

        public void AdaugaSala(Sala sala)
        {
            sali.Add(sala);
        }

        public void StergeSala(int id)
        {
            sali.RemoveAll(s => s.Id == id);
        }

        public Sala CautaSala(int id)
        {
            return sali.FirstOrDefault(s => s.Id == id);
        }

        public List<Sala> ObtineSali()
        {
            return sali;
        }
    }
}
