using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlog2.Models
{
    public class BlogPostModel : BaseModel
    {
        public string Title { get; set; }
        public string Authorname { get; set; }
        public DateTime CreatedAt { get; set; }
        public string BlogBody { get; set; }

    }
}
