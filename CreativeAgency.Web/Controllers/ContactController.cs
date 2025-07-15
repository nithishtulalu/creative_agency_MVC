using CreativeAgency.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CreativeAgency.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public ContactController(ApplicationDBContext context)
        {
            _dbContext = context;
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                _dbContext.ContactForms.Add(model); 
                await _dbContext.SaveChangesAsync();
                ViewBag.Message = "Thank You for Your enquiry !";
                ModelState.Clear();
            }
            return View();

        }
    }
}