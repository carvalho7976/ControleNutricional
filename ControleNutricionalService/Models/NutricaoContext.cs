﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace ControleNutricionalService.Models
{
    public class NutricaoContext : DbContext
    {
        public NutricaoContext()
            : base()
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Alimento> Alimentos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var mapAlimento = modelBuilder.Entity<Alimento>();
            mapAlimento.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            mapAlimento.HasKey(a => a.Id);

            modelBuilder.Entity<Refeicao>()
                .HasMany<Alimento>(rf => rf.Alimentos)
                .WithMany(a => a.Refeicoes)
                .Map(arf =>
                    {
                        arf.MapLeftKey("RefeicaoRefId");
                        arf.MapRightKey("AlimentosRefId");
                        arf.ToTable("RefeicaoAlimentos");
                    });
        }
    }
}