using OverseerAPI.Models.User;

namespace OverseerAPI.ViewModel
{
    public class UserInfoViewModel
    {
        public UserInfoViewModel ()
        {
        }

        public string Email { get; set; }

        public bool HasRegistered { get; set; }

        public string ApiKey { get; set; }
        public string LoginProvider { get; set; }

        public User User { get; set; }
    }
}
