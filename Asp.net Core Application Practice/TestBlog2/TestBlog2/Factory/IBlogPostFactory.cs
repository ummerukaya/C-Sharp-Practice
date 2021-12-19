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
        List<BlogPostModel> PrepareBlogPosts(List<BlogPost> blogPosts);

        BlogPostModel PrepareBlogPostModel(BlogPost blogPost);
        BlogPost PrepareBlogPost(BlogPostModel blogPostModel);
    }
}
