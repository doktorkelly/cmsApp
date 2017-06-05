using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cmsApp.Model;

namespace cmsApp.Services
{
    public class WPService : ICMSService
    {
        public IEnumerable<Blog> FindAll()
        {
            //TODO
            return new List<Blog>();
        }

        public Blog FindById(int id)
        {
            //TODO
            return null;
        }

        public Blog FindByTitle(string title)
        {
            //TODO
            return null;
        }
    }
}
