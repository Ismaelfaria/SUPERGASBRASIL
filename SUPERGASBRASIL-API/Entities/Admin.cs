namespace SUPERGASBRASIL_API.Entities
{
    public class Admin
    {
        public Guid IdAdmin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }

        public Admin(string username, string password)
        {
            Username = username;
            Password = password;
            IsDeleted = false;
        }
        public void Update(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
