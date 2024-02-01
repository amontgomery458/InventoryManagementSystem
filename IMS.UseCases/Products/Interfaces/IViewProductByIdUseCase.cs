using IMS.CoreBusiness;

namespace IMS.UseCases.Products
{
    public interface IViewProductByIdUseCase
    {
        Task<Product?> ExecuteAsync(int productId);
    }
}