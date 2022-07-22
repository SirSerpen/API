using Microsoft.AspNetCore.Mvc;

namespace LearnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
    //    private readonly DataContext _context;

    //    public ProductController(DataContext context)
    //    {
    //        _context = context;
    //    }

    //    [HttpGet]
    //    public async Task<ActionResult<List<Product>>> Get()
    //    {
    //        return Ok(await _context.Product.ToListAsync());
    //    }

    //    [HttpGet("{id}")]
    //    public async Task<ActionResult<List<Product>>> Get(int id)
    //    {
    //        var product = await _context.Product.FindAsync(id);
    //        if (product == null)
    //            return BadRequest("Product not found.");
    //        return Ok(product);
    //    }

    //    [HttpPost]
    //    public async Task<ActionResult<List<Product>>> AddProduct(Product product) 
    //    {
    //        _context.Product.Add(product);
    //        await _context.SaveChangesAsync();

    //        return Ok(await _context.Product.ToListAsync());
    //    }

    //    [HttpPut]
    //    public async Task<ActionResult<List<Product>>> UpdateProduct(Product request)
    //    {
    //        var dbProduct = await _context.Product.FindAsync(request.ID);
    //        if (dbProduct == null)
    //            return BadRequest("Product not found");

    //        dbProduct.Name = request.Name;
    //        dbProduct.Description = request.Description;

    //        await _context.SaveChangesAsync();

    //        return Ok(await _context.Product.ToListAsync());
    //    }

    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult<List<Product>>> Delete(int id)
    //    {
    //        var dbProduct = await _context.Product.FindAsync(id);
    //        if (dbProduct == null)
    //            return BadRequest("Product not found.");

    //        _context.Product.Remove(dbProduct);
    //        await _context.SaveChangesAsync();

    //        return Ok(await _context.Product.ToListAsync());
    //    }
    }
}
