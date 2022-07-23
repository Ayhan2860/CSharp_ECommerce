namespace MvcWebUI.Models
{
    public class UserDetailsViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }= false;
    }
}