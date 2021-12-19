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
        public void UpdateBlogPost(BlogPost blogPost)
        {
            var bp = (from s in Datas.blogPosts
                     where s.Id == blogPost.Id
                     select s).FirstOrDefault();
            
            var ind = Datas.blogPosts.IndexOf(bp);
            Datas.blogPosts[ind] = blogPost;
        }

        public void InsertBlogPost(BlogPost blogPost)
        {
            var bp = Datas.blogPosts.LastOrDefault();

            if (bp == null)
            {
                blogPost.Id = 1;
            }
            else
            {
                blogPost.Id = bp.Id + 1;
            }
            Datas.blogPosts.Add(blogPost);
        }
    }
}
