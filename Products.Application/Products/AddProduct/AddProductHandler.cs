using MediatR;
using Products.Application.Services;
using Products.Persistence.Context;
using Products.Persistence.Entities;

namespace Products.Application.Products.AddProduct
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, int>
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMathService _mathService;

        public AddProductHandler(AppDbContext appDbContext, IMathService mat)
        {
            _appDbContext = appDbContext;
            _mathService = mat;
        }

        public async Task<int> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            //
            var myList = new List<int> { 1, 2, 3, 5, 7, 9, 3, 432, 23, 432 };

            var x = _mathService.Sort(myList);

            var productToAdd = new Product
            {
                Name = request.Data.Name,
                Price = request.Data.Price
            };

            _appDbContext.Products.Add(productToAdd);
            _appDbContext.SaveChanges();

            return productToAdd.Id;
        }
    }
}
