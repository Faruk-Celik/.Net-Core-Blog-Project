using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreProject.WebUI.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager cm = new CommentManager( new EfCommentRepository());
        public IViewComponentResult Invoke (int id)
        {
            var values = cm.TListAllComment(id);
            return View(values);
        }
    }
}
