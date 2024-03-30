

namespace SHoper.Model
{
    public class UserAsClient
    {
        public int UserAsClientID { get; set; }
        
        public string? UsernameInForum { get; set; }
        public virtual Basket? Basket { get; set; }
    }
}
