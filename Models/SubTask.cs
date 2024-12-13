using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class SubTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartLine { get; set; }
        public DateTime DeadtLine { get; set; }
        public String Progress { get; set; }
        public String State { get; set; }
        public int Emp_Id { get; set; }
        public int BTask_Id { get; set; }

        [ForeignKey("Emp_Id")]
        public Employee Employee{ get; set; }

        [ForeignKey("BTask_Id")]
        public BigTask BigTask { get; set; }

    }
}
