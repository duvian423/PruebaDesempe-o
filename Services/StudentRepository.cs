using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaConocimiento.Data;
using PruebaConocimiento.Models;

namespace PruebaConocimiento.Services
{
    public class StudentRepository : IStudentRepository
    {
        public readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public void CreateStudent(Student student)
        {   
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public IEnumerable<Enrollment> GetAllEnrollmentsByStudent(int Id)
        {
            var student = _context.Students.Find(Id);
            return _context.Enrollments.Where(e => e.StudentId == student.Id).ToList();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int Id)
        {
            return _context.Students.Find(Id);
        }

        public void UpdateStudent(int Id,Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }
    }
}