using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ODOO.Models;

namespace ODOO.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly ODOO.Models.OdooDBContext _context=new OdooDBContext();


        [BindProperty]
        public EventEvent EventEvent { get; set; }

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

        //Elimina el elemento selecionado
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EventEvent = await _context.EventEvent.FindAsync(id); //Obtiene la id del evento actual

            if (EventEvent != null)
            {
                _context.EventEvent.Remove(EventEvent); //Elimina el evento con la id que se ha obtenido anteriormente y guarda los cambios
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
