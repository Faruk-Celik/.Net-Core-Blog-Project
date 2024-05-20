using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.WebUI.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager Wm = new WriterManager(new EfWriterRepository());

        public IViewComponentResult Invoke ()
        {
            var values = Wm.TGetWriterById(3);
            return View(values);
        }
    }
}
