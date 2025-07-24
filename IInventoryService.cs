public interface IInventoryService
{
    Task<List<Item>> GetAllItemsAsync();
    Task AddItemAsync(Item item);
}
