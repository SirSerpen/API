namespace Products.Application.Services.Implementations
{
    public class MathService : IMathService
    {
        public List<int> Sort(List<int> toSort)
        {
            //dapustim am cea mai zamudrionaia logica de sortare
            return toSort.OrderBy(x=>x).ToList();
        }
    }
}
