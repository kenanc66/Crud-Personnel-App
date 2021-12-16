using System.ComponentModel.DataAnnotations;

namespace ProjeIT.Models
{
    
    public class Personnel
    {
        public int PersonnelId { get; set; }
        [Required(ErrorMessage ="Please enter your Identity Number")]
        [StringLength(11,MinimumLength = 11, ErrorMessage ="Enter 11 digits please")]
        public string IdentityNumber { get; set; }
        [Required]
        public string Name { get; set; }
        public string Position { get; set; }
        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage ="Please enter a valid email adress.")]
        public string Email { get; set; }
        public string Adress { get; set; }
        public string BirthPlace { get; set; }
        [Required(ErrorMessage = "Please enter your Phone Number")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Enter at least 10 digits please")]
        public string PhoneNumber { get; set; }
        public string SecondaryNumber { get; set; }
        public string BloodType { get; set; }
        public string LastGraduation { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }


    }
}
