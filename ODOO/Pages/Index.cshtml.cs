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
    public class IndexModel : PageModel
    {
        private readonly ODOO.Models.OdooDBContext _context=new OdooDBContext();

        

        public IList<EventEvent> EventEvent { get;set; }

        /// <summary>
        /// Genera una lista
        /// </summary>
        /// <returns>Devuelve una lista de Eventos de forma asincrona</returns>
        public async Task OnGetAsync()
        {
            EventEvent = await _context.EventEvent.ToListAsync();
        }
    }
}
