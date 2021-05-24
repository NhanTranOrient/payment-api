using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using payment_api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace payment_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {

        }

        [HttpGet]
        public Product GetProduct()
        {
            return new Product
            {
                Id = 1,
                Name = "Printed Chiffon Dress",
                Price = 60
            };
        }
    }
}
