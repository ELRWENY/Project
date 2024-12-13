using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string ? Name { get; set; }
        public int Age { get; set; }
        public String ? Email { get; set; }
        public string? Adress { get; set; }
        public string Password { get; set; }
        // Foreign Keys
        public int Dept_Id { get; set; }
        public int Super_Id { get; set; }


        [ForeignKey("Dept_Id")]
        public Department Department { get; set; }

        [ForeignKey("Super_Id")]
        public SuperVisor superVisor { get; set; }

        public List<SubTask> SubTasks { get; set; }=new List<SubTask>();

    }
}
