using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Turnero.Data;
using Api.Turnero.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Turnero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnoController : ControllerBase
    {
        private readonly ApiContext context;

        public TurnoController(ApiContext context)
        {
            this.context = context;
        }
        #region Get

        //Get de La lista Entera.
        [HttpGet]
        public ActionResult<List<Turno>> Get()
        {
            return context.Turnos.ToList();
        }

        //por id.
        [HttpGet("{id}", Name = "ObtenerTurnoporId")]
        public ActionResult<Turno> Get(int id)
        {
            var turno = context.Turnos.FirstOrDefault(p => p.Id == id);
            if (turno == null)
            {
                return NotFound();

            }
            return turno;
        }
        #endregion

        #region Post


        [HttpPost]
        public async Task<ActionResult<Turno>> Post([FromBody] Turno turno)
        {

            await context.Turnos.AddAsync(turno);

            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerturnoporid", new { id = turno.Id }, turno);


        }

        #endregion
        #region Put
        [HttpPut("{id}")]
        public ActionResult<Turno> Put(int id, [FromBody] Turno turno)
        {
            if (id != turno.Id)
            {
                return BadRequest();
            }
            context.Entry(turno).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        #endregion
        #region Delete

        [HttpDelete("{id}")]
        public ActionResult<Turno> Delete(int id)
        {
            var turno    = context.Turnos.FirstOrDefault(p => p.Id == id);
            if (turno == null)
            {
                return NotFound();
            }
            context.Turnos.Remove(turno);
            context.SaveChanges();
            return Ok();
        }
        #endregion
    }
}
