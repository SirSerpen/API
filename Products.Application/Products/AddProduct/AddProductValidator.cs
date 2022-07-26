using FluentValidation;

namespace Products.Application.Products.AddProduct
{
    public class AddProductValidator : AbstractValidator<AddProductCommand>
    {
        public AddProductValidator()
        {
            RuleFor(x => x.Data.Name).NotEmpty().WithMessage("Nume gol");
        }

    }
}
