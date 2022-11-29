using ECommerceAPI.Application.Abstract;
using ECommerceAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Concrete
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
       => new()
       {
           new (){Id=Guid.NewGuid(),Name="Product 1",Price=100,Stock=10},
           new (){Id=Guid.NewGuid(),Name="Product 1",Price=200,Stock=20},
           new (){Id=Guid.NewGuid(),Name="Product 1",Price=300,Stock=30},
           new (){Id=Guid.NewGuid(),Name="Product 1",Price=400,Stock=40},
           new (){Id=Guid.NewGuid(),Name="Product 1",Price=500,Stock=50},
           new (){Id=Guid.NewGuid(),Name="Product 1",Price=600,Stock=60}
       };
    }
}
