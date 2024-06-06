using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaConocimiento.Models;
using PruebaConocimiento.Services;

namespace PruebaConocimiento.Controllers.Teachers
{

    public class UpdateTeacherController : ControllerBase
    {
        public readonly ITeacherRepository _teacherRepository;
        public UpdateTeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpPut("api/teachers/{Id}")]
        public IActionResult UpdateTeacher(int Id, [FromBody] Teacher teacher)
        {
            if(teacher == null){
                return NoContent();
            }
            _teacherRepository.UpdateTeacher(Id, teacher);
            return Ok("Se actualizo el profesor");
        }
    }
}