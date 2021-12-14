namespace ProjeIT.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public List<Personnel> Personnels { get; set; } = new List<Personnel>();
    }
}
