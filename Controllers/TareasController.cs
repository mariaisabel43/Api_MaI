using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaApi.DatabaseHelper;
using PruebaApi.Models;

namespace PruebaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {        
        private readonly AppDbContext _context;

        public TareasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<TareasController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tareas = await _context.Tareas.ToListAsync();
            return Ok(tareas);
        }

       // GET api/<TareasController>/5
       [HttpGet("{id}")]
       public async Task<IActionResult> Get(int id)
       {
       var tarea = await _context.Tareas.FindAsync(id);
       if (tarea == null) return NotFound();
           return Ok(tarea);
       }

       // POST api/<TareasController>
       [HttpPost]
       public async Task<IActionResult> PostCrear([FromBody] Tarea tarea)
       {
           if (!ModelState.IsValid) return BadRequest(ModelState);

                _context.Tareas.Add(tarea);
                await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = tarea.Id }, tarea);
        }

        // PUT api/<TareasController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActualizar(int id, [FromBody] Tarea tarea)
        {
            if (id != tarea.Id) return BadRequest();
            if (!ModelState.IsValid) return BadRequest(ModelState);

                _context.Entry(tarea).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return NoContent();
            }

            // DELETE api/<TareasController>/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(int id)
            {
                if (id <= 0) return BadRequest("El ID debe ser positivo.");

                var tarea = await _context.Tareas.FindAsync(id);
                if (tarea == null) return NotFound();

                try
                {
                    _context.Tareas.Remove(tarea);
                    await _context.SaveChangesAsync();
                    return NoContent(); // O `Ok(tarea)` si prefieres confirmar lo eliminado
                }
                catch (Exception ex)
                {
                    return StatusCode(500, "Error interno al eliminar la tarea.");
                }
            }


            [HttpGet("estado/{estado}")]
            public async Task<IActionResult> FiltrarPorEstado(bool estado)
            {
                var tareas = await _context.Tareas.Where(t => t.EstadoT == estado).ToListAsync();
                return Ok(tareas);
            }

            [HttpGet("ordenar/{prioridad}")]
            public async Task<IActionResult> FiltrarPorPrioridad(string prioridad)
            {
                if (string.IsNullOrEmpty(prioridad))
                {
                    return BadRequest("Debe especificar una prioridad.");
                }

                var tareasFiltradas = await _context.Tareas
                    .Where(t => t.Prioridad.ToLower() == prioridad.ToLower())
                    .ToListAsync();

                if (!tareasFiltradas.Any())
                {
                    return NotFound($"No hay tareas con la prioridad '{prioridad}'.");
                }

                return Ok(tareasFiltradas);
            }

            [HttpGet("buscar/{texto}")]
            public async Task<IActionResult> Buscar(string texto, int limit = 20)
            {
                var tareas = await _context.Tareas
                    .Where(t => t.Titulo.Contains(texto) || t.Descripcion.Contains(texto))
                    .Take(limit)
                    .ToListAsync();
                return Ok(tareas);
            }
        }
    
}
