using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TemplateBootstrap.Models;

namespace TemplateBootstrap.Context
{
    public class Contexto : DbContext
    {
        public DbSet<funcionarioModel> Funcionarios { get; set; }
    }
}