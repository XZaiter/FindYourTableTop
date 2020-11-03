﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly FYTT.Data.FYTTContext _context;

        public IndexModel(FYTT.Data.FYTTContext context)
        {
            _context = context;
        }

        public IList<Form> Form { get;set; }

        public async Task OnGetAsync()
        {
            Form = await _context.Form.ToListAsync();
        }
    }
}
