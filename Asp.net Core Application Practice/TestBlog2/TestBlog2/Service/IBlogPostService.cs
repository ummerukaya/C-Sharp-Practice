using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog2.Entity;

namespace TestBlog2.Service
{
    public interface IBlogPostService
    {
        List<BlogPost> GetAllBlogPosts();

        BlogPost GetBlogPost(int id);

        BlogPost UpdateBlogPost(BlogPost blogPost);

        BlogPost DeleteBlogPost(BlogPost blogPost);
        
    }
}
