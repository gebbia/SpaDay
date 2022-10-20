using System.ComponentModel.DataAnnotations;


namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "You must enter a username.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "You must enter a valid password.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please re-enter your password.")]
        [Compare("Password", ErrorMessage = "Passwords must match!")]
        public string VerifyPassword { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public AddUserViewModel(string username, string email, string password, string verifyPassword)
        {
            Username = username;
            Email = email;
            Password = password;
            VerifyPassword = verifyPassword;
        }

        public AddUserViewModel()
        {

        }
    }
}
