using System.ComponentModel.DataAnnotations;

namespace CFA_EmployeeDetails.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId{ get; set; }
        [Required]
        public int EmployeeName { get; set; }
        [Required]
        public int EmployeeAge { get; set; }
        public string? Department { get; set; }
    }
}
