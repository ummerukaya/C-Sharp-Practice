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

        BlogPost GetBlogPostById(int id);

        void UpdateBlogPost(BlogPost blogPost, BlogPost updatedBlogPost);

        void DeleteBlogPost(BlogPost blogPost);
        
    }
}
