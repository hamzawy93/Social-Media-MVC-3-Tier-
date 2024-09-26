using Social_Media.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media.BLL.Service.Abstraction
{
    public interface IpostService
    {
        List<Post> GetPosts();
        Post GetPostByID(int id);
        bool Create(Post post);
        bool Update(Post post);
    }
}
