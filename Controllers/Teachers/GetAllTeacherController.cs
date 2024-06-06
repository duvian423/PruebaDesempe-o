using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaConocimiento.Models;
using PruebaConocimiento.Services;

namespace PruebaConocimiento.Controllers.Teachers
{

    public class GetAllTeacherController : ControllerBase
    {
        public readonly ITeacherRepository _teacherRepository;
        public GetAllTeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpGet]
        [Route("api/teachers")]
        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _teacherRepository.GetAllTeachers();
        }

        [HttpGet]
        [Route("api/teachers/{Id}")]
        public Teacher GetTeacherById(int Id)
        {
            return _teacherRepository.GetTeacherById(Id);
        }

        [HttpGet]
        [Route("api/teacherss/{Id}")]
        public IEnumerable<Course> GetCoursesByTeacher(int Id)
        {
            return _teacherRepository.GetAllCourseByTeacher(Id);
        }
    }
}