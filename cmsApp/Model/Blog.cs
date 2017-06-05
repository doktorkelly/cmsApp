using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cmsApp.Model
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedAt { get; set; }

        public Blog(int id, string title, string content, DateTime? created)
        {
            this.Id = id;
            this.Title = title;
            this.Content = content;
            this.CreatedAt = created;
        }
    }
}
