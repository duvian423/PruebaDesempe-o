using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaConocimiento.Models;
using PruebaConocimiento.Services;

namespace PruebaConocimiento.Controllers.Enrollments
{

    public class GetAllEnrollmentsController : ControllerBase
    {
        public readonly IEnrollmentRepository _enrollmentRepository;
        public GetAllEnrollmentsController(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        [HttpGet]
        [Route("api/enrollments")]
        public IEnumerable<Enrollment> GetAllEnrollments()
        {
            return _enrollmentRepository.GetAllEnrollments();
        }

        [HttpGet]
        [Route("api/enrollments/{Id}")]
        public Enrollment GetEnrollmentById(int Id)
        {
            return _enrollmentRepository.GetEnrollmentById(Id);
        }

        [HttpGet]
        [Route("api/enrollmentss/")]
        public IEnumerable<Enrollment> GetAllEnrollmentsById(DateTime date)
        {
            return _enrollmentRepository.GetAllEnrollmentsByDate(date);
        }
    }
}