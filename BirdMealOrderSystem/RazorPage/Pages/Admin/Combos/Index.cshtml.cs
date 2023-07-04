﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BussinessObject;
using Repository;

namespace RazorPage.Pages.Admin.Combos
{
    public class IndexModel : PageModel
    {
        IComboRepository comboRepository = new ComboRepository();
        public List<Combo> Combo { get;set; }

        public async Task<IActionResult> OnGetAsync()
        {
            if (!SessionHelper.checkPermission(HttpContext.Session, "admin"))
            {
                return Redirect("~/ErrorRole");
            }
            Combo = comboRepository.GetAll(true);
            Combo.AddRange(comboRepository.GetAll(false));
            return Page();
        }
    }
}
