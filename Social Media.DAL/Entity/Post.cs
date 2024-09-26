using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media.DAL.Entity
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? image { get; set; }
        public string? Description { get; set; }
        public int? UserID {  get; set; }   
        public bool ? IsDeleted { get; set; }
        public User? User { get; set; }

    }
}
