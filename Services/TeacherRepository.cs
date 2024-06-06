using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaConocimiento.Data;
using PruebaConocimiento.Models;

namespace PruebaConocimiento.Services
{
    public class TeacherRepository : ITeacherRepository
    {
        public readonly DataContext _context;
        public TeacherRepository(DataContext context)
        {
            _context = context;
        }

        public void CreateTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
        }

        public IEnumerable<Course> GetAllCourseByTeacher(int Id)
        {
            var teacher = _context.Teachers.Find(Id);
            return _context.Courses.Where(c => c.TeacherId == teacher.Id).ToList();
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetTeacherById(int Id)
        {
            return _context.Teachers.Find(Id);
        }

        public void UpdateTeacher(int Id, Teacher teacher)
        {
            _context.Teachers.Update(teacher);
            _context.SaveChanges();
        }
    }
}