using ProjeIT.Context;
using ProjeIT.Models;

namespace ProjeIT.Services
{
    public class DepartmentManager : IDepartmentService
    {
        ProjeITContext db;
        public DepartmentManager(ProjeITContext _db)
        {
            db = _db;
        }

        public void CreateDepartment(Department department)
        {
            db.Add(department);
            db.SaveChanges();
        }

        public void DeleteDepartment(int id)
        {
            Department department = db.Department.FirstOrDefault(s => s.DepartmentId == id);

            if (department != null)
            {
                db.Remove(department);
                db.SaveChanges();
            }

        }

        public IEnumerable<Department> GetAllDepartments()
        {
           
            return (db.Department.Select(s => s).ToList());
        }

        public void UpdateDepartment(int id)
        {
            Department department = db.Department.FirstOrDefault(s => s.DepartmentId == id);
            db.Update(id);
            db.SaveChanges();
        }
    }
}
