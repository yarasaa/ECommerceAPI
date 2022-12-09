using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository,IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            //_productWriteRepository.AddRangeAsync(new() { 
            //new() { Id=Guid.NewGuid(),ProductName="Test Ürün",Price=100,CreatedDate=DateTime.UtcNow,Stock=10},
            //new() { Id=Guid.NewGuid(),ProductName="Test Ürün1",Price=200,CreatedDate=DateTime.UtcNow,Stock=20},
            //new() { Id=Guid.NewGuid(),ProductName="Test Ürün2",Price=300,CreatedDate=DateTime.UtcNow,Stock=30},
            //});
            //await _productWriteRepository.SaveAsync();

          Product product=  await _productReadRepository.GetByIdAsync("d917922e-f550-48b6-9aa0-a5c38bfcd595",false);
            product.ProductName = ".Net6";
            _productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product=await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }

    }
}
