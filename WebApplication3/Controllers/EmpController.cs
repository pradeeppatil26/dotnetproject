using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Repository;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private IGenericRepository<Employee> deprepo;
        public EmpController(IGenericRepository<Employee> _deprepo)
        {
            this.deprepo = _deprepo;
        }
        [HttpGet]
        [Route("")]
        public IEnumerable<Employee> GetAllBooks()
        {
            var lst = deprepo.GetAll().SelectMany(x=>x.dept.employes);



            return lst;
        }
    }
}