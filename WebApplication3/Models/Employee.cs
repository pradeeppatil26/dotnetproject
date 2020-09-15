using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeptID { get; set; }
      public virtual Dept dept { get; set; }
    }
    public class Dept
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employee> employes { get; set; }
    }
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
