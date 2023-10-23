using Ecommerce_Backend_DotNet.Context;
using EcommerceBackend_DotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Backend_DotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly AppDBContext _appDBContext;

        public AdminController(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }




        [HttpGet]
        [Route("product/{id}")]
        public async Task<IActionResult> GetProductByID(int id)
        {
             var product = await _appDBContext.Products.FindAsync(id);
            return Ok(product);
        }

        [HttpPost]
        [Route("addProducts")]
        public async Task<IActionResult> AddProducts(Products product)
        {
            await _appDBContext.Products.AddAsync(product);
            await _appDBContext.SaveChangesAsync();
            return Ok("Product Added Succesfully");
        }

        [HttpDelete]
        [Route("deleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _appDBContext.Products.FindAsync(id);
            _appDBContext.Products.Remove(product);
            await _appDBContext.SaveChangesAsync();

            return Ok("Product Deleted");
        }

        [HttpPut]
        [Route("updateProduct")]
        public async Task<IActionResult> UpdateProduct(Products product)
        {
            _appDBContext.Entry(product).State = EntityState.Modified;
            await _appDBContext.SaveChangesAsync();
            return Ok("Product updated");
        }


        [HttpGet]
        [Route("users")]
        public async Task<ActionResult<IEnumerable<Users>>> GetAllUsers()
        {
            var users = await _appDBContext.Users.ToListAsync();
            return Ok(users);
        }


        [HttpGet]
        [Route("orders")]
        public async Task<ActionResult<IEnumerable<OrderItems>>> GetAllOrders()
        {
            var orders = await _appDBContext.Orders.ToListAsync();
            return Ok(orders);
        }


    }
}
