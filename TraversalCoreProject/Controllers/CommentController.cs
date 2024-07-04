using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager manager = new CommentManager(new EfCommentDal());
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.CommentDate=DateTime.Now;
            comment.CommentStatus = true;
            manager.TInsert(comment);
            return RedirectToAction("Index","Destination");
        }
    }
}
