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
    public class PostRepo : IpostRepo
    {
        ApplicationDbContext Db = new ApplicationDbContext();

        public bool Create(Post post)
        {
            try
            {
                Db.Posts.Add(post);
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
                var Result = Db.Posts.Where(a => a.Id == id).FirstOrDefault();
                if (Result != null)
                {
                    Result.IsDeleted = !Result.IsDeleted;

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


        public Post GetPostByID(int id)
        {
            var Result = Db.Posts.Where(a => a.Id == id).FirstOrDefault();
            return Result;

        }

        public List<Post> GetPosts()
        {
            var Result = Db.Posts.Where(a => a.IsDeleted != false).ToList();
            return Result;

        }

        public bool Update(Post post)
        {
            var Result = Db.Users.Where(a => a.Id == post.Id).FirstOrDefault();
            if (Result != null)
            {
                Result.FullName = post.Title;
                Result.Email = post.Description;
                Result.Password = post.image;
                Result.age = post.Id;
                Db.SaveChanges();
                return true;

            }
            return false;
        }

       
        }
    }
