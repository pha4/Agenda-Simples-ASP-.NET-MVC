using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq.Expressions;
using agenda.Models;

namespace agenda.DAO
{
    public class AgendaContext:DbContext
    {
        public AgendaContext():base("contatos"){}

        public DbSet<Contato> Contatos { get; set; }


    }
}