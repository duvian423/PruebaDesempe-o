using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaConocimiento.Data;
using PruebaConocimiento.Models;

namespace PruebaConocimiento.Services
{
    public class CourseRepository : ICourseRepository
    {
        public readonly DataContext _context;
        public CourseRepository(DataContext context)
        {
            _context = context;
        }

        public void CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        public Course GetCourseById(int Id)
        {
            return _context.Courses.Find(Id);
        }

        public void UpdateCourse(int Id, Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
        }
    }
}