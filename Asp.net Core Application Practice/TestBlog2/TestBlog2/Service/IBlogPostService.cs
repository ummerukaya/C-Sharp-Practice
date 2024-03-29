﻿using System;
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

        void InsertBlogPost(BlogPost blogPost);

        void UpdateBlogPost(BlogPost blogPost);

        void DeleteBlogPost(BlogPost blogPost);
        
    }
}
