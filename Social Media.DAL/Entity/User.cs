using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media.DAL.Entity
{
    public class User
    {
        public int Id { get; set; }
        public int age { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public bool isdeleteted { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public List<Post> Posts { get; set; }

    }
}
