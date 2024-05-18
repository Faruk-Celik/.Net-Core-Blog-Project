using Microsoft.AspNetCore.Mvc;

namespace CoreProject.WebUI.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
