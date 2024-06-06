using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PruebaConocimiento.Models
{
    public class Course
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int TeacherId { get; set; }

        [Required]
        public string Schedule { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public int Capacity { get; set; }


        [JsonIgnore]
        public Teacher Teacher { get; set; }

        [JsonIgnore]
        public List<Student> Students { get; set; }
        
    }
}