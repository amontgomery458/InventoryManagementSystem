using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace IMS.Plugins.EFCoreSqlServer
{
    public class InventoryEFCoreRepository : IInventoryRepository
    {
        private readonly IDbContextFactory<IMSContext> contextFactory;

        public InventoryEFCoreRepository(IDbContextFactory<IMSContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task AddInventoryAsync(Inventory inventory)
        {
            using var db = this.contextFactory.CreateDbContext();
            
            db.Inventories.Add(inventory);

            await db.SaveChangesAsync();
            
           
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            using var db = this.contextFactory.CreateDbContext();
            return await db.Inventories.Where(
                x => x.InventoryName.ToLower().IndexOf(name.ToLower()) >= 0).ToListAsync();
            
        }

        public async Task<Inventory> GetInventoryByIdAsync(int inventoryId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var inv = await db.Inventories.FindAsync(inventoryId);

            if (inv != null) return inv;

            return new Inventory();
           
        }

        public async Task UpdateInventoryAsync(Inventory inventory)
        {
            using var db = this.contextFactory.CreateDbContext();
            var inv = await db.Inventories.FindAsync(inventory.InventoryId);
            if (inv != null)
            {
                inv.InventoryName = inventory.InventoryName;
                inv.Price = inventory.Price;
                inv.Quantity = inventory.Quantity;

                await db.SaveChangesAsync();
            }
        }
    }
}