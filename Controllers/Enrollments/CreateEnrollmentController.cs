using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaConocimiento.Models;
using PruebaConocimiento.Services;

namespace PruebaConocimiento.Controllers.Enrollments
{

    public class CreateEnrollmentController : ControllerBase
    {
        public readonly IEnrollmentRepository _enrollmentRepository;
        public CreateEnrollmentController(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        [HttpPost("api/enrollments")]
        public IActionResult CreateEnrollment([FromBody] Enrollment enrollment)
        {
            if (enrollment == null){
                return NoContent();
            }
            _enrollmentRepository.CreateEnrollment(enrollment);
            return Ok("Se ha creado su matricula");
        }
    }
}