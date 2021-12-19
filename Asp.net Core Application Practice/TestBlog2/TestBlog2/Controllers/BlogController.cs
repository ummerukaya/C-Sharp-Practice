using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog2.DataSource;
using TestBlog2.Entity;
using TestBlog2.Factory;
using TestBlog2.Models;
using TestBlog2.Service;

namespace TestBlog2.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogPostService _blogPostService;
        private readonly IBlogPostFactory _blogPostFactory;

        public BlogController(IBlogPostService blogPostService,
                              IBlogPostFactory blogPostFactory)
        {
            _blogPostService = blogPostService;
            _blogPostFactory = blogPostFactory;
        }
        // GET: HomeController1
        [Route("Blog")]
        public IActionResult GetAll()
        {
            var blogPosts = _blogPostService.GetAllBlogPosts();
            
            var models = _blogPostFactory.PrepareBlogPosts(blogPosts);

            return View(models);
        }

        // GET: HomeController1/Details/5
        [HttpGet]
        [Route("Blog/Details/{id}")]
        public IActionResult Details(int id)
        {
            var blogPost = _blogPostService.GetBlogPostById(id);
            if (blogPost == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                var model = _blogPostFactory.PrepareBlogPostModel(blogPost);
                return View(model);
            }
        }

        // GET: HomeController1/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogPostModel blogPostModel)
        {
            try
            {
                var blogPost = _blogPostFactory.PrepareBlogPost(blogPostModel);
                _blogPostService.InsertBlogPost(blogPost);
              
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        [HttpGet]
        [Route("Blog/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var blogPost = _blogPostService.GetBlogPostById(id);
            if (blogPost == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                var model = _blogPostFactory.PrepareBlogPostModel(blogPost);
                return View(model);
            }
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BlogPostModel blogPostModel)
        {
            try
            {

                var blogPost = _blogPostService.GetBlogPostById(blogPostModel.Id);

                if (blogPost != null)
                {
                    blogPost = _blogPostFactory.PrepareBlogPost(blogPostModel);
                    _blogPostService.UpdateBlogPost(blogPost);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        [HttpGet]
        [Route("Blog/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var blogPost = _blogPostService.GetBlogPostById(id);
            if (blogPost == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                var model = _blogPostFactory.PrepareBlogPostModel(blogPost);
                return View(model);
            }
            
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(BlogPostModel blogPostModel)
        {
            try
            {
                var blogPost = _blogPostFactory.PrepareBlogPost(blogPostModel);
                var b = _blogPostService.GetBlogPostById(blogPost.Id);
                if (b != null)
                {
                    _blogPostService.DeleteBlogPost(b);
                }
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
