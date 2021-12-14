namespace ProjeIT.Models
{
    public class Personnel
    {
        public int PersonnelId { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string BirthPlace { get; set; }
        public string PhoneNumber { get; set; }
        public string SecondaryNumber { get; set; }
        public string BloodType { get; set; }
        public string LastGraduation { get; set; }
        public Department Department { get; set; }

    }
}
