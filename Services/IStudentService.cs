using OrarUniversitar.Services;
using System.Collections.Generic;

namespace OrarUniversitar.Services
{
    public interface IStudentService
    {
        void AdaugaStudent(Student student);
        void StergeStudent(int id);
        Student CautaStudent(int id);
        List<Student> ObtineStudenti();
    }
}