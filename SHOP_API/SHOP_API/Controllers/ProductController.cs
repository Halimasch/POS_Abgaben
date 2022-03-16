using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SHOP_API.DAL;
using SHOP_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public List<Products> getAllProducts()
        {
            return ProductDatabase.getInstance().GetProducts();
        }

        [HttpGet("{id}")]
        public ActionResult<Products> getProduct(int id)
        {
            Products p = ProductDatabase.getInstance().GetProductById(id);
            if(p is null)
            {
                return NotFound();
            }
            return p;
        }

    }
}
