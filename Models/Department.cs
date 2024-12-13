using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Super_Id { get; set; }

        [ForeignKey("Super_Id")]
        public SuperVisor SuperVisor { get; set; }

        public List<Employee> Employees { get; set; }= new List<Employee>();
        public List<BigTask> BigTasks{ get; set; }= new List<BigTask>();


    }
}
