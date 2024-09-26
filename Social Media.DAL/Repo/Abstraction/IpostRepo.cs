using Social_Media.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media.DAL.Repo.Abstraction
{
    public interface IpostRepo
    {
        List<Post> GetPosts();
        Post GetPostByID(int id);
        bool Create(Post post);
        bool Update(Post post);
        bool Delete(int id);
    }
}
