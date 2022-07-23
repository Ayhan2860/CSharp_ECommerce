using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcWebUI.Models;

namespace MvcWebUI.ViewsComponents
{
    public class UserSummaryViewComponent:ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            
            UserDetailsViewModel model = new UserDetailsViewModel
            {
                 UserName = HttpContext.User.Identity.Name,
                 IsAdmin = HttpContext.User.IsInRole("Admin")
                 
            };
            return View(model);
        }
    }
}