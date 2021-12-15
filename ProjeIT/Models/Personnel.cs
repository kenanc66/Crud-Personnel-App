using System.ComponentModel.DataAnnotations;

namespace ProjeIT.Models
{
    public class Personnel
    {
        public int PersonnelId { get; set; }
        [Required]
        [StringLength(11,ErrorMessage ="Enter 11 digits please")]
        public string IdentityNumber { get; set; }
        [Required]
        public string Name { get; set; }
        public string Position { get; set; }
        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage ="Please enter a valid email adress.")]
        public string Email { get; set; }
        public string Adress { get; set; }
        public string BirthPlace { get; set; }
        public string PhoneNumber { get; set; }
        public string SecondaryNumber { get; set; }
        public string BloodType { get; set; }
        public string LastGraduation { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }


    }
}
