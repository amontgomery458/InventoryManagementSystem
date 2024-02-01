using IMS.CoreBusiness;

namespace IMS.UseCases.Products
{
    public interface IEditProductUseCase
    {
        Task ExecuteAsync(Product product);
    }
}