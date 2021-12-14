using ProjeIT.Models;

namespace ProjeIT.Services
{
    public interface IDepartmentService
    {
        public IEnumerable<Department> GetAllDepartments();
        public void DeleteDepartment(int id);
        
        public void CreateDepartment(Department department);
        public void UpdateDepartment(int id);
    }
}
