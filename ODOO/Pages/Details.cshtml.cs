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
    public class DetailsModel : PageModel
    {
        private readonly ODOO.Models.OdooDBContext _context=new OdooDBContext();


        public EventEvent EventEvent { get; set; }

        //Obtiene los detalles del evento seleccionado
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
    }
}
