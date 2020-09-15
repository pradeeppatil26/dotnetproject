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
    public class DeptController : ControllerBase
    {
        private IGenericRepository<Dept> deprepo;
        public DeptController(IGenericRepository<Dept> _deprepo)
        {
            this.deprepo = _deprepo;
        }
        [HttpGet]
        [Route("")]
        public IEnumerable<Dept> GetAllBooks()
        {
          return  deprepo.GetAll();
        }
        [HttpGet]
        [Route("{bookId}")]
        public Dept GetBookById(int Id) => deprepo.GetById(Id);
    }
}