using System.ComponentModel.DataAnnotations;

namespace WebAppA.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Salary { get; set; }

        [Required]
        public string Address { get; set; }
    }
    }
