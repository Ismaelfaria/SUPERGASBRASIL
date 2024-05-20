namespace SUPERGASBRASIL_API.Mappers.Models.ViewModel
{
    public class Admin_ViewModel
    {
        public Guid IdAdmin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
    }
}
