﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MMC2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MHCAEntities : DbContext
    {
        public MHCAEntities()
            : base("name=MHCAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Historico> Historicos { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Setore> Setores { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<TipoSkill> TipoSkills { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<vw_relatorio_projeto> vw_relatorio_projeto { get; set; }
    }
}
