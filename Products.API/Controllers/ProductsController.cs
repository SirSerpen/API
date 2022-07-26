using MediatR;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Products.AddProduct;
using Products.DTO.Products;

namespace LearnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<int> AddProduct(AddEditProductDto data)
        {
            return await _mediator.Send(new AddProductCommand(data));
        }


        [HttpDelete("{id}")]
        public async Task DeleteProduct([FromRoute] int id)
        {

        }
    }
}
