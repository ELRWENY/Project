using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class BigTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartLine { get; set; }
        public DateTime DeadtLine { get; set; }
        public String Progress { get; set; } 
        public String State { get; set; }
        public int Dept_Id { get; set; }
        public int Super_Id { get; set; }

        [ForeignKey("Super_Id")]
        public SuperVisor SuperVisor { get; set; }

        [ForeignKey("Dept_Id")]
        public Department Department{ get; set; }

        List<SubTask> SubTasks { get; set; }= new List<SubTask>();
        
    }
}
