using Social_Media.BLL.Service.Abstraction;
using Social_Media.DAL.Database;
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
    public class UserService :IUserService
    {
        IUserRepo service = new UserRepo();

        public bool Create(User user)
        {
            try
            {
                return service.Create(user);
               
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

        public bool DeleteAll()
        {
            throw new NotImplementedException();
        }

        public User GetUserByID(int id) =>service.GetUserByID(id);
        

        public List<User> GetUsers() => service.GetUsers();
 
        public bool Update(User user)
        {
     return service.Update(user);
            
        }
    }
}