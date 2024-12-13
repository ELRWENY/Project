using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class SuperVisor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public String? Email { get; set; }
        public string? Adress { get; set; }
        public string Password { get; set; }
        public int Dept_Id { get; set; }

        [ForeignKey("Dept_Id")]
        public Department Department { get; set; }

        List<Employee> Employees { get; set; } = new List<Employee>();
        List<BigTask> BigTasks { get; set; } = new List<BigTask>();

    }
}
