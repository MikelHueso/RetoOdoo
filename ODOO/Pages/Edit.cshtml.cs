using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ODOO.Models;

namespace ODOO.Pages
{
    public class EditModel : PageModel
    {
        private readonly ODOO.Models.OdooDBContext _context=new OdooDBContext();


        [BindProperty]
        public EventEvent EventEvent { get; set; }

        //Obtiene los parametros del elemento seleccionado
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EventEvent = await _context.EventEvent.FirstOrDefaultAsync(m => m.Id == id);

            if (EventEvent == null)
            {
                return NotFound();
            }
            return Page();
        }

        //Guarda los cambios realizados y redirecciona a la pagina index
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EventEvent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventEventExists(EventEvent.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EventEventExists(int id)
        {
            return _context.EventEvent.Any(e => e.Id == id);
        }
    }
}
