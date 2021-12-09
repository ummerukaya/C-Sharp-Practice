using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog2.Entity;
using TestBlog2.Models;

namespace TestBlog2.DataSource
{
    public class Datas
    {
        public static List<BlogPost> blogPostsModels = new List<BlogPost>()
        {
            new BlogPost()
            {
                Id=1,
                Authorname="Umme",
                CreatedAt = DateTime.Now,
                BlogBody = "lorem lorem",
                Title = "Dummy"
            },
             new BlogPost()
            {
                Id=2,
                Authorname="Umme",
                CreatedAt = DateTime.Now,
                BlogBody = "lorem lorem",
                Title = "Dummy"
            },
              new BlogPost()
            {
                Id=3,
                Authorname="Umme",
                CreatedAt = DateTime.Now,
                BlogBody = "lorem lorem",
                Title = "Dummy"
            },
               new BlogPost()
            {
                Id=4,
                Authorname="Umme",
                CreatedAt = DateTime.Now,
                BlogBody = "lorem lorem",
                Title = "Dummy"
            },
        };
    }
}
