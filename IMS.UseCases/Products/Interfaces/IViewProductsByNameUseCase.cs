using IMS.CoreBusiness;

namespace IMS.UseCases.Products
{
    public interface IViewProductsByNameUseCase
    {
        Task<IEnumerable<Product>> ExecuteAsync(string name = "");
    }
}