namespace API.DTOs
{
    public class MemberDTO
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public int Age { get; set; }

        public string KnownAs { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastActive { get; set; }

        public string Gender { get; set; }

        public string Inroduction { get; set; }

        public string LookingFor { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public ICollection<PhotoDTO> Photos { get; set; }
    }
}