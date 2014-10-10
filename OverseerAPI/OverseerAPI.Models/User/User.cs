using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OverseerAPI.Models.User
{
    public class User
    {
        public User()
        {
        }

        public User(string id, string username)
        {
            AspNetUserId = id;
            Username = username;
        }

        [Key]
        public string AspNetUserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AvatarColor { get; set; }
        public string InitialsColor { get; set; }
        public string Initials { get; set; }
        public int? TeamId { get; set; }
        public Team Team { get; set; }
    }
}
