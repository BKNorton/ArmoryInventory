using ArmoryInventory.Domain.Models;

namespace ArmoryInventory.Data.Interfaces
{
    public interface IRepository
    {
        public Task<Task> AddItemAsync(Item item);
        public Task RemoveItem(Item item);
        public Task<List<Item>> GetItemsAsync();
        public Task<Item> GetItemByIdAsync(string id);
        public Task<List<Item>> GetItemsBySearchAsync(string filterText);
        public Task<List<Item>> GetItemsByFiltersAsync(int typeIndex, int hasCompIndex, int missCapIndex, int checkOutIndex);
        public Task<Task> UpdateItemAsync(Guid Id, Item item);

        //Currently not needed
        //public Task<List<Checkout>> GetCheckoutHistoryAsync(string Id);
    }
}
