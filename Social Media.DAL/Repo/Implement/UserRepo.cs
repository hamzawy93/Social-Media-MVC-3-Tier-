using Social_Media.DAL.Database;
using Social_Media.DAL.Entity;
using Social_Media.DAL.Repo.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media.DAL.Repo.Implement
{
    public class UserRepo : IUserRepo

    {
        ApplicationDbContext Db = new ApplicationDbContext();

        public bool Create(User user)
        {
            try
            {
                Db.Users.Add(user);
                Db.SaveChanges();
                return true;
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
                var Result = Db.Users.Where(a => a.Id == id).FirstOrDefault();
                if (Result != null)
                {
                    Result.isdeleteted = !Result.isdeleteted;

                    Db.SaveChanges();
                    return true;
                }
                return false;
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

        public User GetUserByID(int id)
        {
            var Result = Db.Users.Where(a => a.Id == id).FirstOrDefault();
            return Result;

        }

        public List<User> GetUsers()
        {
            var Result = Db.Users.Where(a => a.isdeleteted != false).ToList();
            return Result;

        }

        public bool Update(User user)
        {
            var Result = Db.Users.Where(a => a.Id == user.Id).FirstOrDefault();
            if (Result != null)
            {
                Result.FullName = user.FullName;
                Result.Email = user.Email;
                Result.Password = user.Password;
                Result.age = user.age;
                Db.SaveChanges();
                return true;

            }
            return false;
        }
    }
}