using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Publess.Service.Posts;
using Publess.Core.Data;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Publess.Admin.Controllers
{
    public class PostController : Controller
    {
        private IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        // GET: /Post/
        public IActionResult Index()
        {
            IEnumerable<Post> posts = _postService.GetPosts().ToList();

            return View(posts);
        }

        // GET: /Post/CreateEdit/
        [HttpGet]
        public IActionResult CreateEdit(int? id)
        {
            Post post = new Post();

            //if (id.HasValue && id != 0)
            //{
            //    //Post=_postService.
            //}

            return View(post);
        }

        // POST: /Post/CreateEdit/
        [HttpPost]
        public IActionResult CreateEdit(Post post)
        {
            post.PostBodyHtml = post.PostBodyText;
            post.InsertedOn = DateTime.Now;
            post.InsertedBy = 0;
            post.UpdatedOn = DateTime.Now;
            post.UpdatedBy = 0;

            _postService.InsertPost(post);

            return RedirectToAction("Index");
        }

    }
}
