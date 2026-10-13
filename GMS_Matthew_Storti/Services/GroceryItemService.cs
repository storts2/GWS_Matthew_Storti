using GMS_Matthew_Storti.DataAccessLayer;
using GMS_Matthew_Storti.Models;

namespace GMS_Matthew_Storti.Services;

public class GroceryItemService : IGroceryItemService
{
    private readonly GroceryDBContext _context;

    public GroceryItemService(GroceryDBContext context)
    {
        _context = context;
    }

    public List<GroceryItem> GetAllItems()
    {
        return _context.Items.ToList();
    }

    public GroceryItem GetItemById(int id)
    {
        return _context.Items.FirstOrDefault(i => i.Id == id);
    }

    public GroceryItem AddItem(GroceryItem item)
    {
        _context.Items.Add(item);
        _context.SaveChanges();
        return item;
    }

    public GroceryItem UpdateItem(GroceryItem item)
    {
        _context.Items.Update(item)
        _context.SaveChanges();
        return item;
    }

    public GroceryItem DeleteItemById(int id)
    {
        GroceryItem item = GetItemById(id)

        _context.Remove(item);
        _context.SaveChanges();

        return item;
    }

    public List<GroceryItem> GetItemsByCategory(string category)
    {
        return _context.Items.Where(i => i.Category == category).ToList();
    }

    public List<GroceryItem> GetItemsGreaterThanPrice(double price)
    {
        return _context.Items.Where(i => i.Price > price).ToList();
    }
}
