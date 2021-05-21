using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContaCorrente_02.Models;

namespace ContaCorrente_02.DAL
{
    public class ContaCorrente_02Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Movimento> Movimentos { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}