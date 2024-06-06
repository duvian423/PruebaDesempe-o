using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaConocimiento.Models;

namespace PruebaConocimiento.Services
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAllTeachers();
        IEnumerable<Course> GetAllCourseByTeacher(int Id);
        Teacher GetTeacherById(int Id);
        void CreateTeacher(Teacher teacher);
        void UpdateTeacher(int Id ,Teacher teacher);
    }
}