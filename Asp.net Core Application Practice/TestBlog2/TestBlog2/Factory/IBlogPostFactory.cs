using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog2.Entity;
using TestBlog2.Models;

namespace TestBlog2.Factory
{
    public interface IBlogPostFactory
    {
        List<BlogPostsModel> PrepareBlogPosts(List<BlogPost> blogPosts);

        BlogPostsModel PrepareBlogPost(BlogPost blogPost);
    }
}
