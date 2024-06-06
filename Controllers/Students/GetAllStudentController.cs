using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaConocimiento.Models;
using PruebaConocimiento.Services;

namespace PruebaConocimiento.Controllers.Students
{

    public class GetAllStudentController : ControllerBase
    {
        public readonly IStudentRepository _studentRepository;
        public GetAllStudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        [Route("api/students")]
        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        [HttpGet]
        [Route("api/student/{Id}")]
        public Student GetStudentById(int Id)
        {
            return _studentRepository.GetStudentById(Id);
        }

        [HttpGet]
        [Route("api/studentss/{Id}")]
        public IEnumerable<Enrollment> GetAllEnrollmentById(int Id)
        {
            return _studentRepository.GetAllEnrollmentsByStudent(Id);
        }
    }
}