﻿using Microsoft.EntityFrameworkCore;
using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Registro.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =DESKTOP-9RKG0AB\SQLEXPRESS; Database = PersonasDb; Trusted_Connection = True; ");
        }
    }
    

    
}
