namespace EcommerceBackend_DotNet.Models
{
    public class Response
    {

        public Guid StatusCode { get; set; }

        public string StatusMessage { get; set; }


        // User
        public List<Users> userList { get; set; }

        public Users user { get; set; }


        //products
        public List<Products> productsList { get; set; }

        public Products product { get; set; }
        

        // carts
        public List<Cart> cartList { get; set; }


        //orders
        public List<Orders> ordersList { get; set; }

        public Orders order { get; set; }


        // orderItems
        public List<OrderItems> orderItemsList { get; set; }

        public OrderItems orderItems { get; set;}




    }
}
