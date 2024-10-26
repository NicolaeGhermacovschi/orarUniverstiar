using OrarUniversitar.Services;
using System.Collections.Generic;
using System.Linq;

namespace OrarUniversitar.Services
{
    public class OrarService : IOrarService
    {
        private readonly List<Orar> ore = new List<Orar>();

        public void AdaugaOrar(Orar orar)
        {
            ore.Add(orar);
        }

        public void StergeOrar(int id)
        {
            ore.RemoveAll(o => o.Id == id);
        }

        public Orar CautaOrar(int id)
        {
            return ore.FirstOrDefault(o => o.Id == id);
        }

        public List<Orar> ObtineOre()
        {
            return ore;
        }
    }
}
