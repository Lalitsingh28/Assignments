namespace EcommerceBackend_DotNet.Models
{
    public class Products
    {

        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public int Quantity { get; set; }

        public string ImageURL { get; set; }

        public int Status { get; set; }

        public string InsersionType { get; set; }
    }
}
