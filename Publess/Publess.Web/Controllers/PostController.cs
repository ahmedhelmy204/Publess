using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
//using Publess.Service.Posts;
//using Publess.Core.Data;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Publess.Web.Controllers
{
    public class PostController : Controller
    {
        //private IPostService _postService;

        //public PostController(IPostService postService)
        //{
        //    _postService = postService;
        //}

        // GET: /Post/
        public IActionResult Index()
        {
            //IEnumerable<Post> posts = null; // _postService.GetPosts().ToList();

            //return View(posts);
            return View();
        }
    }
}
