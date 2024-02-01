using IMS.CoreBusiness;

namespace IMS.UseCases.Activities
{
    public interface IProduceProductUseCase
    {
        Task ExecuteAsync(string productionNumber, Product product, int quantity, string doneby);
    }
}