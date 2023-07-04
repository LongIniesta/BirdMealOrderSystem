using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BussinessObject;
using Repository;

namespace RazorPage.Pages.Admin.Combos
{
    public class EditModel : PageModel
    {
        IComboRepository comboRepository = new ComboRepository();
        IComboDetailRepository comboDetailRepository = new ComboDetailRepository();
        [BindProperty]
        public Combo Combo { get; set; }
        public List<ComboDetail> ComboDetails { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Combo = comboRepository.GetById((int) id);
            ComboDetails = new List<ComboDetail>();
            foreach (ComboDetail cbd in Combo.ComboDetails.ToList())
            {
                ComboDetail cbd1 = comboDetailRepository.GetAll().Where(c => c.ProductId == cbd.ProductId && c.ComboId == Combo.ComboId).SingleOrDefault();
                if (cbd1 != null)
                {
                    ComboDetails.Add(cbd1);
                }
            }

            if (Combo == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ComboDetails = new List<ComboDetail>();
                foreach (ComboDetail cbd in Combo.ComboDetails.ToList())
                {
                    ComboDetail cbd1 = comboDetailRepository.GetAll().Where(c => c.ProductId == cbd.ProductId && c.ComboId == Combo.ComboId).SingleOrDefault();
                    if (cbd1 != null)
                    {
                        ComboDetails.Add(cbd1);
                    }
                }
                return Page();
            }


            try
            {
                comboRepository.Update(Combo);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComboExists(Combo.ComboId))
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

        private bool ComboExists(int id)
        {
            return comboRepository.GetById((int) id) != null;
        }
    }
}
