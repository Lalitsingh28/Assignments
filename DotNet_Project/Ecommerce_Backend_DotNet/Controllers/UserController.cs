using Ecommerce_Backend_DotNet.Context;
using Ecommerce_Backend_DotNet.Models;
using EcommerceBackend_DotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Backend_DotNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly AppDBContext _appDBContext;

        public UserController(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }


        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(Users user)
        {
            _appDBContext.Users.Add(user);
            await _appDBContext.SaveChangesAsync();
            return Ok("User register Successfully");
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginModule loginModule)
        {
            var user = _appDBContext.Users.FirstOrDefault(u => u.Email == loginModule.Email);
            if (user != null)
            {
                if (user.Password == loginModule.Password)
                {
                    return Ok("Login Successfull");
                }
            }
            return BadRequest("Invalid Username or Password");

        }


        [HttpPut]
        [Route("user")]
        public async Task<IActionResult> UpdateUser(Users user)
        {
            _appDBContext.Entry(user).State = EntityState.Modified;
            await _appDBContext.SaveChangesAsync();
            return Ok("User Profile Updated");
        }



        [HttpGet]
        [Route("products")]
        public async Task<ActionResult<IEnumerable<Products>>> GetProducts()
        {
            var products = await _appDBContext.Products.ToListAsync();
            return Ok(products);
        }



        [HttpGet]
        [Route("cart")]
        public async Task<ActionResult<IEnumerable<Cart>>> GetCartItems()
        {
            var cart = await _appDBContext.Cart.ToListAsync();
            return Ok(cart);
        }



    }

}

