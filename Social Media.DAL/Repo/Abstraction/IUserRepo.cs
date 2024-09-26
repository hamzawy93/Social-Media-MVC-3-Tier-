using Social_Media.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media.DAL.Repo.Abstraction
{
    public interface IUserRepo
    {
        List<User> GetUsers();
        User GetUserByID(int id);
        bool Create( User user);    
        bool Update( User user );   
        bool Delete( int id );   
        bool DeleteAll();   

    }
}
