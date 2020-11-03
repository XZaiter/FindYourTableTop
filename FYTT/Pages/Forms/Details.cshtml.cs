using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FYTT.Data;
using FYTT.models;

namespace FYTT.Pages.Forms
{
    public class DetailsModel : PageModel
    {
        private readonly FYTT.Data.FYTTContext _context;

        public DetailsModel(FYTT.Data.FYTTContext context)
        {
            _context = context;
        }

        public Form Form { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Form = await _context.Form.FirstOrDefaultAsync(m => m.ID == id);

            if (Form == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
