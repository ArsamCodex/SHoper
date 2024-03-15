

namespace SHoper.Model
{
    public class UserAsClient
    {
        public int UserAsClientID { get; set; }
        public string? UsernameInForum { get; set; }
        public List<Items> Items { get; set; } = new List<Items>();
    }
}
