using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaConocimiento.Data;
using PruebaConocimiento.Models;

namespace PruebaConocimiento.Services
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        public readonly DataContext _context;
        public EnrollmentRepository(DataContext context)
        {
            _context = context;
        }

        public void CreateEnrollment(Enrollment enrollment)
        {
            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();
        }

        public IEnumerable<Enrollment> GetAllEnrollments()
        {
            return _context.Enrollments.ToList();
        }

        public IEnumerable<Enrollment> GetAllEnrollmentsByDate(DateTime date)
        {
            return _context.Enrollments.Where(e => e.Date == date).ToList();
        }

        public Enrollment GetEnrollmentById(int Id)
        {
            return _context.Enrollments.Find(Id);
        }

        public void UpdateEnrollment(int Id, Enrollment enrollment)
        {
            _context.Enrollments.Update(enrollment);
            _context.SaveChanges();
        }
    }
}