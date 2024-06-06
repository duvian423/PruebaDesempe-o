using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaConocimiento.Models;
using PruebaConocimiento.Services;

namespace PruebaConocimiento.Controllers.Students
{

    public class UpdateStudentController : ControllerBase
    {
        public readonly IStudentRepository _studentRepository;
        public UpdateStudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpPut("api/students/{Id}")]
        public IActionResult UpdateStudent(int Id, [FromBody] Student student)
        {
            if (student == null){
                return NoContent();
            }    
            _studentRepository.UpdateStudent(Id, student);
            return Ok("Se actualizo el estudiante");
        }
    }
}