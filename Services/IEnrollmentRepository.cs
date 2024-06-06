using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaConocimiento.Models;

namespace PruebaConocimiento.Services
{
    public interface IEnrollmentRepository
    {
        IEnumerable<Enrollment> GetAllEnrollments();
        IEnumerable<Enrollment> GetAllEnrollmentsByDate(DateTime date);
        Enrollment GetEnrollmentById(int Id);
        void CreateEnrollment(Enrollment enrollment);
        void UpdateEnrollment(int Id ,Enrollment enrollment);
    }
}