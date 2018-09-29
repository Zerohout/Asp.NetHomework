using Microsoft.AspNetCore.Mvc;

namespace AkhmerovHomeWork.ViewComponents
{
    public class LoginLogoutViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
