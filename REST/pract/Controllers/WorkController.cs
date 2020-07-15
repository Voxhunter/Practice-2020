using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using pract.Models;

namespace pract.Controllers
{
    [Route("api/Work")]
    [ApiController]
    public class WorkController : ControllerBase
    {
        private readonly WorkContext _context;
        public WorkController(WorkContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetWorks()
        {
            var works = _context.Work.ToList();
            return Ok(works);
        }

        [HttpGet("{id}")]
        public IActionResult GetWorksbyId(int id)
        {
            var work = _context.Work.Find(id);
            if (work == null)
            {
                return NotFound();
            }
            return Ok(work);
        }

        [HttpPost("{name}/{id}")]
        public IActionResult PostWork(string name, int id)
        {
            var work = new Work()
            {
                work_Name = name,
                comp_Id = id
            };
            _context.Add(work);
            _context.SaveChanges();
            return Ok("Created");
        }

        [HttpPut("{id}/{rename}/{id2}")]
        public IActionResult PutWork(int id, string rename, int id2)
        {
            var work = _context.Work.Find(id);
            if (work == null)
            {
                return NotFound();
            }
            work.work_Name = rename;
            work.comp_Id = id2;
            _context.Work.Update(work);
            _context.SaveChanges();
            return Ok("Update");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWork(int id)
        {
            var work = _context.Work.Find(id);
            if (work == null)
            {
                return NotFound();
            }
            _context.Work.Remove(work);
            _context.SaveChanges();
            return Ok("Deleted");
        }
    }
}

