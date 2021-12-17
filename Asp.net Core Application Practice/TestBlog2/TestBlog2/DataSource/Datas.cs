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
       
        public static List<BlogPost> blogPosts = new List<BlogPost>()
        {
            new BlogPost()
            {
                Id=1,
                Authorname="Umme Rukaya",
                CreatedAt = DateTime.Now,
                BlogBody = "Galaxies are groups of stars and other " +
                "space objects held together by gravity. There are more " +
                "than 100 billion galaxies in the universe, each presenting" +
                " beautiful structures that can be seen in telescope images " +
                "taken of the distant universe.",
                Title = "Galaxy"
            },
             new BlogPost()
            {
                Id=2,
                Authorname="Umme Rukaya",
                CreatedAt = DateTime.Now,
                BlogBody = "Galaxies are groups of stars and other " +
                "space objects held together by gravity. There are more " +
                "than 100 billion galaxies in the universe, each presenting" +
                " beautiful structures that can be seen in telescope images " +
                "taken of the distant universe.",
                Title = "Galaxy"
            },
              new BlogPost()
            {
                Id=3,
                Authorname="Umme Rukaya",
                CreatedAt = DateTime.Now,
                BlogBody = "Galaxies are groups of stars and other " +
                "space objects held together by gravity. There are more " +
                "than 100 billion galaxies in the universe, each presenting" +
                " beautiful structures that can be seen in telescope images " +
                "taken of the distant universe.",
                Title = "Galaxy"
            },
               new BlogPost()
            {
                Id=4,
                Authorname="Umme Rukaya",
                CreatedAt = DateTime.Now,
                BlogBody = "Galaxies are groups of stars and other " +
                "space objects held together by gravity. There are more " +
                "than 100 billion galaxies in the universe, each presenting" +
                " beautiful structures that can be seen in telescope images " +
                "taken of the distant universe.",
                Title = "Galaxy"
            },
        };
    }
}
