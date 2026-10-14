using GMS_Matthew_Storti.Models;
using GMS_Matthew_Storti.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GMS_Matthew_Storti.Pages
{
    public class CategoryModel : PageModel
    {
        private readonly IGroceryItemService _service;

        public CategoryModel(IGroceryItemService service)
        {
            _service = service;
            Items = new List<GroceryItem>();
        }

        [BindProperty]
        public string? CurrentCategory { get; set; }
        public List<GroceryItem> Items { get; set; }

        public void OnGet()
        {
            Items = _service.GetAllItems();
        }

        public void OnPostCategory() 
        { 
            if (CurrentCategory is  null || CurrentCategory == "")
            {
                CurrentCategory = "Invalid input, no category selected";
                Items = _service.GetAllItems();
            }
            else
            {
                Items = _service.GetItemsByCategory(CurrentCategory);
            }
        }
    }
}
