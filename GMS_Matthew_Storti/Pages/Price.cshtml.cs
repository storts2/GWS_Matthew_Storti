using GMS_Matthew_Storti.Models;
using GMS_Matthew_Storti.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GMS_Matthew_Storti.Pages
{
    public class PriceModel : PageModel
    {
        private readonly IGroceryItemService _service;

        public PriceModel(IGroceryItemService service)
        {
            _service = service;
            Items = new List<GroceryItem>();
        }

        [BindProperty]
        public double CurrentPrice { get; set; }

        public List<GroceryItem> Items { get; set; }

        public void OnGet()
        {
            Items = _service.GetAllItems();
        }

        public void OnPostPrice()
        {
            if (CurrentPrice < 0)
            {
                CurrentPrice = 0;
                Items = _service.GetItemsGreaterThanPrice(CurrentPrice);
            }
            else
            {
                Items = _service.GetItemsGreaterThanPrice(CurrentPrice);
            }
            
        }
    }
}
