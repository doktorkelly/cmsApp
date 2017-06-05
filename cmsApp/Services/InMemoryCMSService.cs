using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cmsApp.Model;

namespace cmsApp.Services
{
    public class InMemoryCMSService : ICMSService
    {
        private static IEnumerable<Blog> Blogs = new List<Blog>() {
            new Blog(1, "title1", "content1", DateTime.Now),
            new Blog(1, "title2", "content2", DateTime.Now),
            new Blog(1, "title3", "xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx ", DateTime.Now)
        };

        public IEnumerable<Blog> FindAll()
        {
            IEnumerable<Blog> blogs = Blogs.ToList();
            return blogs;
        }

        public Blog FindById(int id)
        {
            Blog blog = Blogs
                .Where(bl => bl.Id == id)
                .FirstOrDefault();
            return blog;
        }

        public Blog FindByTitle(string title)
        {
            Blog blog = Blogs
                .Where(bl => bl.Title == title)
                .FirstOrDefault();
            return blog;
        }
    }
}
