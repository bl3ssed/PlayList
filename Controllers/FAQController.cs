using Microsoft.AspNetCore.Mvc;
using PlayList.Models;

namespace PlayList.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult Index() //faq
        {
            return View();
        }
        [HttpPost]
        public IActionResult Check(FAQ faq) //faq
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}
