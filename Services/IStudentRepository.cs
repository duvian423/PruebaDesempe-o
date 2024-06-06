using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaConocimiento.Models;

namespace PruebaConocimiento.Services
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Enrollment> GetAllEnrollmentsByStudent(int Id);
        Student GetStudentById(int Id);
        void CreateStudent(Student student);
        void UpdateStudent(int Id ,Student student);
    }
}