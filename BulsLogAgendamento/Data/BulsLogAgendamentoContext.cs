using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BulsLogAgendamento.Models;

namespace BulsLogAgendamento.Data
{
    public class BulsLogAgendamentoContext : DbContext
    {
        public BulsLogAgendamentoContext (DbContextOptions<BulsLogAgendamentoContext> options)
            : base(options)
        {
        }

        public DbSet<BulsLogAgendamento.Models.Agendamento> Agendamento { get; set; }
    }
}
