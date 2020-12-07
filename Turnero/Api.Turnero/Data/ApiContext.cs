using Api.Turnero.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Turnero.Data
{
    public class ApiContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
        public DbSet<Turno> Turnos { get; set; }
    }
}
