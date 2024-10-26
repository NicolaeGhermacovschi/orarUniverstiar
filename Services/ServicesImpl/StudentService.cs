using OrarUniversitar.Services;
using System.Collections.Generic;
using System.Linq;

namespace OrarUniversitar.Services
{
    public class StudentService : IStudentService
    {
        private readonly List<Student> studenti = new List<Student>();

        public void AdaugaStudent(Student student)
        {
            studenti.Add(student);
        }

        public void StergeStudent(int id)
        {
            studenti.RemoveAll(s => s.Id == id);
        }

        public Student CautaStudent(int id)
        {
            return studenti.FirstOrDefault(s => s.Id == id);
        }

        public List<Student> ObtineStudenti()
        {
            return studenti;
        }
    }
}
