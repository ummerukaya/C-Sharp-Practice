using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog2.Entity;
using TestBlog2.Models;

namespace TestBlog2.Factory
{
    public class BlogPostFactory : IBlogPostFactory
    {
        public BlogPostsModel PrepareBlogPost(BlogPost blogPost)
        {
            var model = new BlogPostsModel();
            model.Id = blogPost.Id;
            model.Title = blogPost.Title;
            model.Authorname = blogPost.Authorname;
            model.CreatedAt = blogPost.CreatedAt;
            model.BlogBody = blogPost.BlogBody;
            return model;
        }

        public List<BlogPostsModel> PrepareBlogPosts(List<BlogPost> blogPosts)
        {
            var models = new List<BlogPostsModel>();
            for(var i = 0; i < blogPosts.Count; i++)
            {
                models.Add(new BlogPostsModel()
                {
                    Id = blogPosts[i].Id,
                    Title = blogPosts[i].Title,
                    Authorname = blogPosts[i].Authorname,
                    CreatedAt = blogPosts[i].CreatedAt,
                    BlogBody = blogPosts[i].BlogBody
                }) ;
            }
            return models;
        }
    }
}
