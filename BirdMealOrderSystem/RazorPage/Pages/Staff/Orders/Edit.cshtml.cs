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

namespace RazorPage.Pages.Staff.Orders
{
    public class EditModel : PageModel
    {
        IUserRepository userRepository = new UserRepository();
        IOrderRepository orderRepository = new OrderRepository();   

        [BindProperty]
        public Order Order { get; set; }
        public string Message { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = orderRepository.GetById((int)id);

            if (Order == null)
            {
                return NotFound();
            }
            List<string> listStatus = new List<string>();
            listStatus.Add("Ready");
            listStatus.Add("Shipping");
            listStatus.Add("Shipped");
            ViewData["status"] = new SelectList(listStatus);
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            
            if (!ModelState.IsValid)
            {
                Order = orderRepository.GetById((int)Order.OrderId);
                List<string> listStatus = new List<string>();
                listStatus.Add("Ready");
                listStatus.Add("Shipping");
                listStatus.Add("Shipped");
                ViewData["status"] = new SelectList(listStatus);
                return Page();
            }


           

            try
            {
                if (Order.ShippedDate != null)
                {
                    if (Order.ShippedDate <= Order.OrdeDate)
                    {
                        Order = orderRepository.GetById((int)Order.OrderId);
                        List<string> listStatus = new List<string>();
                        listStatus.Add("Ready");
                        listStatus.Add("Shipping");
                        listStatus.Add("Shipped");
                        ViewData["status"] = new SelectList(listStatus);
                        Message = "Shipped date invalid!";
                        return Page();
                    } else
                    {
                        orderRepository.Update(Order);
                    }
                } else
                {
                    orderRepository.Update(Order);
                }
                
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(Order.OrderId))
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

        private bool OrderExists(int id)
        {
            return orderRepository.GetById((int)id) != null;
        }
    }
}
