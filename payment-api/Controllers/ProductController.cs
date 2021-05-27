using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using payment_api.Infrastructure.Data;
using payment_api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DataModel;
using Microsoft.Extensions.Logging;

namespace payment_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IDynamoDBContext _dynamoDBContext;
        private readonly ILogger<ProductController> _logger;
        public ProductController(IDynamoDBContext dynamoDBContext, ILogger<ProductController> logger)
        {
            _dynamoDBContext = dynamoDBContext;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<Product> GetProduct(int id)
        {
            return await _dynamoDBContext.LoadAsync<Product>(id);
        }

        [HttpGet("list")]
        public async Task<IEnumerable<Product>> GetAll()
        {
            var conditions = new List<ScanCondition>();
            return await _dynamoDBContext.ScanAsync<Product>(conditions).GetRemainingAsync();
        }

        [HttpPost]
        public async Task CreateOrUpdateMany(List<Product> products)
        {
            foreach (var product in products)
                await _dynamoDBContext.SaveAsync(product);
        }

        [HttpDelete]
        public async Task Delete(Product product)
        {
            await _dynamoDBContext.DeleteAsync(product);
        }
    }
}
