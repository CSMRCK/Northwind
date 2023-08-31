using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;

namespace Northwind.Razor.Employees.PacktFeatures.Pages
{
    public class EmployeesPageModel : PageModel
    {
        public Employee[] Employees { get; set; }

        private NorthwindContext db;

        public EmployeesPageModel(NorthwindContext db)
        {
            this.db = db;
        }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind B2B - Employees";

            Employees = db.Employees.OrderBy(e => e.LastName).ThenBy(e=>e.FirstName).ToArray();
        }
    }
}