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
    [Route("api/Comp")]
    [ApiController]
    public class CompController : ControllerBase
    {
        private readonly CompContext _context;
        public CompController(CompContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetComps()
        {
            var comps = _context.Comp.ToList();
            return Ok(comps);
        }

        [HttpGet("{id}")]
        public IActionResult GetCompsbyId(int id)
        {
            var comp = _context.Comp.Find(id);
            if(comp == null)
            {
                return NotFound();
            }
            return Ok(comp);
        }

        [HttpPost("{name}")]
        public IActionResult PostComp(string name)
        {
            var comp = new Comp()
            {
                comp_Name = name
            };
            _context.Add(comp);
            _context.SaveChanges();
            return Ok("Created");
        }

        [HttpPut("{id}/{rename}")]
        public IActionResult PutComp(int id, string rename)
        {
            var comp = _context.Comp.Find(id);
            if (comp == null)
            {
                return NotFound();
            }
            comp.comp_Name = rename;
            _context.Comp.Update(comp);
            _context.SaveChanges();
            return Ok("Update");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteComp(int id)
        {
            var comp = _context.Comp.Find(id);
            if (comp == null)
            {
                return NotFound();
            }
            _context.Comp.Remove(comp);
            _context.SaveChanges();
            return Ok("Deleted");
        }
    } 
}

