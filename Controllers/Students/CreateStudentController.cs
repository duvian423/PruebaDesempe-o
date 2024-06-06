using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaConocimiento.Models;
using PruebaConocimiento.Services;

namespace PruebaConocimiento.Controllers.Students
{

    public class CreateStudentController : ControllerBase
    {
        public readonly IStudentRepository _studentRepository;
        public CreateStudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpPost("api/students")]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            if (student == null){
                return NoContent();
            }
            _studentRepository.CreateStudent(student);
            return Ok("Se creo un nuevo estudiante");
        }
    }
}