using GMS_Matthew_Storti.Models;
using GMS_Matthew_Storti.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GMS_Matthew_Storti.Pages
{
    public class ShowItemsModel : PageModel
    {
        private readonly IGroceryItemService _service;

        public ShowItemsModel(IGroceryItemService service)
        {
            _service = service;
            Items = new List<GroceryItem>();
        }

        public List<GroceryItem> Items { get; set; }

        public void OnGet()
        {
            Items = _service.GetAllItems();
        }
    }
}
