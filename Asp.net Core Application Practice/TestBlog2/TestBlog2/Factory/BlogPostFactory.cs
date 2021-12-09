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
            throw new NotImplementedException();
        }

        public List<BlogPostsModel> PrepareBlogPosts(List<BlogPost> blogPosts)
        {
            throw new NotImplementedException();
        }
    }
}
