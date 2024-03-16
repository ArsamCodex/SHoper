namespace SHoper.Model
{
    public class Basket
    {
        public int BasketID { get; set; }
        public virtual ICollection<Items>? Item { get; set; }
        public int? UserAsClientId { get; set; } // Foreign key
        public virtual UserAsClient? UserAsClient { get; set; }
    }
}
