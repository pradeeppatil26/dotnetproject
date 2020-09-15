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
        public virtual IEnumerable<Employee> employes { get; set; }
    }
}
