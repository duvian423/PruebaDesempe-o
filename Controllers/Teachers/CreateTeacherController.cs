using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaConocimiento.Models;
using PruebaConocimiento.Services;

namespace PruebaConocimiento.Controllers.Teachers
{

    public class CreateTeacherController : ControllerBase
    {
        public readonly ITeacherRepository _teacherRepository;
        public CreateTeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpPost("api/teachers")]
        public IActionResult CreateTeacher([FromBody] Teacher teacher)
        {
            if(teacher == null){
                return NoContent();
            }
            _teacherRepository.CreateTeacher(teacher);
            return Ok("Se ha creado un nuevo profesor");
        }
    }
}