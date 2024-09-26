
using Social_Media.BLL.Service.Abstraction;
using Social_Media.DAL.Entity;
using Social_Media.DAL.Repo.Abstraction;
using Social_Media.DAL.Repo.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media.BLL.Service.Implmentation
{
    public class PostService : IpostService
    {
        IpostRepo service = new PostRepo();

        public bool Create(Post post)
        {
            try
            {
                return service.Create(post);

            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Delete(int id)
        {
            try
            {
                return service.Delete(id);


            }
            catch (Exception)
            {
                return false;

            }

        }


        public Post GetPostByID(int id) => service.GetPostByID(id);


        public List<Post> GetPosts() => service.GetPosts();

        public bool Update(Post post)
        {
            return service.Update(post);

        }
    }
}
     