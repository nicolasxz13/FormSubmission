using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Contoller
{
    public class FormSubmission : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("success")]
        public IActionResult Success(User user)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View("Index");
            }
        }
    }
}
