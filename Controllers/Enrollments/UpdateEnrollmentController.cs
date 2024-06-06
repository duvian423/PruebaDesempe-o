using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaConocimiento.Models;
using PruebaConocimiento.Services;

namespace PruebaConocimiento.Controllers.Enrollments
{

    public class UpdateEnrollmentController : ControllerBase
    {
        public readonly IEnrollmentRepository _enrollmentRepository;
        public UpdateEnrollmentController(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        [HttpPut("api/enrollments/{Id}")]
        public IActionResult UpdateEnrollment(int Id, [FromBody] Enrollment enrollment)
        {
            if (enrollment == null){
                return NoContent();
            }
            _enrollmentRepository.UpdateEnrollment(Id, enrollment);
            return Ok("Se ha actualizado su matricula");
        }
    }
}