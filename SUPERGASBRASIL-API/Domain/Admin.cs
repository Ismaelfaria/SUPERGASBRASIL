namespace SUPERGASBRASIL_API.Domain
{
    public class Admin
    {
        public Admin()
        {
            IsDeleted = false;
        }
        public Guid IdAdmin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }

        public void Update(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public void Deleted()
        {
            IsDeleted = true;
        }
    }
}
