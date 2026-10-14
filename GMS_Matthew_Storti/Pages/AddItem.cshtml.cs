using GMS_Matthew_Storti.Models;
using GMS_Matthew_Storti.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GMS_Matthew_Storti.Pages
{
    public class AddItemModel : PageModel
    {
        private readonly IGroceryItemService _service;

        public AddItemModel(IGroceryItemService service)
        {
            _service = service;
            Item = new GroceryItem();
        }

        [BindProperty]
        public GroceryItem Item { get; set; }
        public string? Message { get; set; }

        public void OnGet()
        {
            Message = "Nothing has been entered yet...";
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                Message = "Nothing added incorrect input";
            }
            else
            {
                _service.AddItem(Item);
                Message = $"Entered Item: ({Item.Id}, {Item.Name})" ?? "Entered an Item with no name";
            }
        }
    }
}
