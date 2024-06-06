using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaConocimiento.Models;

namespace PruebaConocimiento.Services
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAllCourses();
        Course GetCourseById(int Id);
        void CreateCourse(Course course);
        void UpdateCourse(int Id ,Course course);
    }
}