using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContaCorrente_02.Models;

namespace ContaCorrente_02.ViewModel
{
    public class ClienteMovimento
    {
        // Coleções de registos (Tabela Cliente e Movimento)
        public IEnumerable<Cliente> Clientes { get; set; }

        public IEnumerable<Movimento> Movimentos { get; set; }
    }
}