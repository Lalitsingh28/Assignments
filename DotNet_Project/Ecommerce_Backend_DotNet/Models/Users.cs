namespace EcommerceBackend_DotNet.Models
{
    public class Users
    {

        public Guid ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Type { get; set; }

        public int Status { get; set; }

        public DateTime CreatedON { get; set; }
    }
}
