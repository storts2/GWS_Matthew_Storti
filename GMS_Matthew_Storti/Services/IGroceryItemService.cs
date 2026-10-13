using GMS_Matthew_Storti.Models;

namespace GMS_Matthew_Storti.Services;

public interface IGroceryItemService
{

    public List<GroceryItem> GetAllItems();

    public GroceryItem GetItemById(int id);

    public GroceryItem AddItem(GroceryItem item);

    public GroceryItem UpdateItem(GroceryItem item);

    public GroceryItem DeleteItemById(int id);

    public List<GroceryItem> GetItemsByCategory(string category);

    public List<GroceryItem> GetItemsGreaterThanPrice(double price);
}
