using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaConocimiento.Models;
using PruebaConocimiento.Services;

namespace PruebaConocimiento.Controllers.Courses
{

    public class GetAllCoursesController : ControllerBase
    {
        public readonly ICourseRepository _courseRepository;
        public GetAllCoursesController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet]
        [Route("api/courses")]
        public IEnumerable<Course> GetAllCourses()
        {
            return _courseRepository.GetAllCourses();
        }

        [HttpGet]
        [Route("api/courses/{Id}")]
        public Course GetCourseById(int Id)
        {
            return _courseRepository.GetCourseById(Id);
        }
    }
}