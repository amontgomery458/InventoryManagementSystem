using IMS.CoreBusiness;

namespace IMS.UseCases.Inventories
{
    public interface IAddInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}