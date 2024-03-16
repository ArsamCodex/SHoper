namespace SHoper.Model
{
    public class Items
    {
        public int ItemsID { get; set; }
        public string? ItemName { get; set; }
        public double ItemPrice { get; set; }
        public string? ImagePath { get; set; }
        public virtual Basket? Basket { get; set; }
        public int? BasketId { get; set; }


    }
}
