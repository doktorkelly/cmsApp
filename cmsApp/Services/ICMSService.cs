using cmsApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cmsApp.Services
{
    public interface ICMSService
    {
        IEnumerable<Blog> FindAll();
        Blog FindById(int id);
        Blog FindByTitle(string title);
    }
}
