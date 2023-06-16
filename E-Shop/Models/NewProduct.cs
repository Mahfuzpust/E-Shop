namespace E_Shop.Models
{
    public class NewProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }
        public string ProductColor { get; set; }
        public bool IsActive { get; set; }
    }
}
