using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ODOO.Models;

namespace ODOO.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ODOO.Models.OdooDBContext _context=new OdooDBContext();


        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public EventEvent EventEvent { get; set; }

        //Guarda los parametros introducidos en la pagina de Create y redirecciona a la pagina de index
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.EventEvent.Add(EventEvent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}