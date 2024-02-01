using IMS.CoreBusiness;

namespace IMS.UseCases.Inventories
{
    public interface IEditInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}