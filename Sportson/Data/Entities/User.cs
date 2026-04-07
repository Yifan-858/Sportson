namespace Sportson.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string Role { get; set; } = ""; // Admin, Partner, Employee
    }
}
//👉 Think of it as your “fake database” for now