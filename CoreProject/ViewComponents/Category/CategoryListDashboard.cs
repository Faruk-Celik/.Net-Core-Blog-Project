using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.WebUI.ViewComponents.Category
{
    public class CategoryListDashboard : ViewComponent
    {
        CategoryManager Cm = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke ()
        {
            var values = Cm.TGetList();
            return View(values);
        }
    }
}
