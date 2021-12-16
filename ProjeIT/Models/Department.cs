﻿namespace ProjeIT.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = "";
        public virtual ICollection<Personnel> Personnels { get; set; }= new List<Personnel>();
    }
}
