using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Controllers
{
    public class AppDbContext : DbContext
    {
        DbSet<Admin> Admins { get; set; }
        DbSet<Department> Departments{ get; set; }
        DbSet<SuperVisor> SuperVisors { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<BigTask> BigTasks{ get; set; }
        DbSet<SubTask> SubTasks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = . ; DataBase = TaskManagement ; TrustServerCertificate = true ; Integrated Security =SSPI ");
        }
    }
}
