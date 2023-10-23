namespace EcommerceBackend_DotNet.Models
{
    public class Orders
    {

        public Guid ID { get; set; }

        public int UserID { get; set; }

        public string OrderNumber { get; set; }

        public decimal OrderTotal { get; set; }

        public string OrderStatus { get; set; }
    }
}
