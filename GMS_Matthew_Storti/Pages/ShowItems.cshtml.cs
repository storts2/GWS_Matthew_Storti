using GMS_Matthew_Storti.Models;
using GMS_Matthew_Storti.Services;
using Microsoft.AspNetCore.DataProtection;
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
            IsSelected = false;
        }

        [BindProperty]
        public int CurrentId { get; set; }

        [BindProperty]
        public GroceryItem CurrentItem { get; set; }

        public bool IsSelected { get; set; }

        public List<GroceryItem> Items { get; set; }

        public void OnGet()
        {
            Items = _service.GetAllItems();
        }

        public void OnPostId()
        {
            IsSelected = true;

            CurrentItem = _service.GetItemById(CurrentId);

            Items = _service.GetAllItems();
        }

        public void OnPostUpdate()
        {
            _service.UpdateItem(CurrentItem);

            Items = _service.GetAllItems();
        }

        public void OnPostDelete()
        {
            _service.DeleteItemById(CurrentId);

            Items = _service.GetAllItems();
        }
    }
}
