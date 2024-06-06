using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaConocimiento.Models;
using PruebaConocimiento.Services;

namespace PruebaConocimiento.Controllers.Courses
{

    public class UpdateCourseController : ControllerBase
    {
        public readonly ICourseRepository _courseRepository;
        public UpdateCourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpPut("api/course/{Id}")]
        public IActionResult UpdateCourse(int id, [FromBody] Course course)
        {
            if(course == null){
                return NoContent();
            }
            _courseRepository.UpdateCourse(id, course);
            return Ok("Se ha actualizado el curso");
        }
    }
}