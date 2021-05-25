using payment_api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace payment_api.Domain.Data
{
    public static class ProductData
    {
        public static IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product { Id = 1,
                Name = "Printed Chiffon Dress 1",
                Price = 10},
                new Product { Id = 2,
                Name = "Printed Chiffon Dress 2",
                Price = 20},
                new Product { Id = 3,
                Name = "Printed Chiffon Dress 3",
                Price = 30},
                new Product { Id = 4,
                Name = "Printed Chiffon Dress 4",
                Price = 40},
                new Product { Id = 5,
                Name = "Printed Chiffon Dress 5",
                Price = 50},
                new Product { Id = 6,
                Name = "Printed Chiffon Dress 6",
                Price = 60},
                new Product { Id = 7,
                Name = "Printed Chiffon Dress 7",
                Price = 70},
                new Product { Id = 8,
                Name = "Printed Chiffon Dress 8",
                Price = 80},
                new Product { Id = 9,
                Name = "Printed Chiffon Dress 9",
                Price = 90},
                new Product { Id = 10,
                Name = "Printed Chiffon Dress 10",
                Price = 100},
                new Product { Id = 11,
                Name = "Printed Chiffon Dress 11",
                Price = 110},
                new Product { Id = 12,
                Name = "Printed Chiffon Dress 12",
                Price = 120},
                new Product { Id = 13,
                Name = "Printed Chiffon Dress 13",
                Price = 130},
                new Product { Id = 14,
                Name = "Printed Chiffon Dress 14",
                Price = 140},
                new Product { Id = 15,
                Name = "Printed Chiffon Dress 15",
                Price = 150},
                new Product { Id = 16,
                Name = "Printed Chiffon Dress 16",
                Price = 160},
                new Product { Id = 17,
                Name = "Printed Chiffon Dress 17",
                Price = 170},
                new Product { Id = 18,
                Name = "Printed Chiffon Dress 18",
                Price = 180},
                new Product { Id = 19,
                Name = "Printed Chiffon Dress 19",
                Price = 190},
                new Product { Id = 20,
                Name = "Printed Chiffon Dress 20",
                Price = 200}
            };
        }
    }
}
