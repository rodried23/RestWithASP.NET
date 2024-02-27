using Microsoft.AspNetCore.Mvc;
using Poc_API_Relatorios_TBFG.Data;
using Poc_API_Relatorios_TBFG.Model;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Poc_API_Relatorios_TBFG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDBContext _context;

        public CategoriasController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/<CategoriasController>
        [HttpGet("Categorias")]
        public ActionResult<IEnumerable<Categorias>> Get()
        {
            var categorias = _context.Categorias.ToList();
            if (categorias is null)
            {
                return NotFound("Categorias não encontrados");
            }

            return categorias;
        }

        // GET api/<CategoriasController>/5
        [HttpGet("{id:int}", Name = "ObterCategoria")]
        public ActionResult<Categorias> Get(int id)
        {
            var categorias = _context.Categorias.FirstOrDefault(x=>x.CategoriaId == id);
            if (categorias is null)
            {
                return NotFound("Categorias não encontrados");
            }

            return categorias;
        }

        // POST api/<CategoriasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoriasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoriasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
