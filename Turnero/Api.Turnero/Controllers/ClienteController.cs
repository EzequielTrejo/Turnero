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
    public class ClienteController : ControllerBase
    {
        private readonly ApiContext context;

        public ClienteController(ApiContext context)
        {
            this.context = context;
        }
        [HttpGet("clienteById/{id}", Name = "ClienteById")]
        public ActionResult<Cliente> GetClienteById(string nombre)
        {
            var cliente  = context.Clientes.FirstOrDefault(p => p.nombre == nombre);
            if (cliente == null)
            {
                return NotFound();
            }
            return cliente;
        }
        [HttpPost]
        public async Task<ActionResult<Cliente>> Post([FromBody] Cliente cliente)
        {

            await context.Clientes.AddAsync(cliente);

            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerclienteporid", new { id = cliente.Id }, cliente);


        }

    }
}
