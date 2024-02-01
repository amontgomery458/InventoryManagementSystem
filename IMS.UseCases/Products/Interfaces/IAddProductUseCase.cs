using IMS.CoreBusiness;

namespace IMS.UseCases.Products
{
    public interface IAddProductUseCase
    {
        Task ExecuteAsync(Product product);
    }
}