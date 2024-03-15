namespace SHoper.Model
{
    public class Items
    {
        public int ItemsID { get; set; }
        public string? ItemName { get; set; }
        public double ItemPrice { get; set; }
        public string? ImagePath { get; set; }


        // Foreign key
        public int? UserAsClientID { get; set; }

        // Navigation property
        public UserAsClient? UserClient { get; set; }
    }
}
