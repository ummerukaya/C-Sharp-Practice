using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog2.DataSource;
using TestBlog2.Entity;
using TestBlog2.Models;

namespace TestBlog2.Service
{
    public class BlogPostService : IBlogPostService
    {
        public BlogPost GetBlogPostById(int id)
        {
           var a = Datas.blogPosts.Where(x => x.Id == id).FirstOrDefault();
           return a;
        }
        public List<BlogPost> GetAllBlogPosts()
        {
            return Datas.blogPosts;
        }
        public void DeleteBlogPost(BlogPost blogPost)
        {
            Datas.blogPosts.Remove(blogPost);
        }
        public void UpdateBlogPost(BlogPost blogPost,BlogPost updatedBlogPost)
        {
            var ind = Datas.blogPosts.IndexOf(blogPost);
            Datas.blogPosts[ind].Title = updatedBlogPost.Title;
            Datas.blogPosts[ind].Authorname = updatedBlogPost.Authorname;
            Datas.blogPosts[ind].CreatedAt = updatedBlogPost.CreatedAt;
            Datas.blogPosts[ind].BlogBody = updatedBlogPost.BlogBody;
        }
    }
}
