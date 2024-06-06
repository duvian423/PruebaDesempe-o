using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaConocimiento.Models;
using PruebaConocimiento.Services;

namespace PruebaConocimiento.Controllers.Courses
{

    public class CreateCourseController : ControllerBase
    {
        public readonly ICourseRepository _courseRepository;
        public CreateCourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpPost("api/courses")]
        public IActionResult CreateCourse([FromBody] Course course)
        {
            if (course == null){
                return NoContent();
            }
            _courseRepository.CreateCourse(course);
            return Ok("Se ha creado un nuevo curso");
        }
    }
}