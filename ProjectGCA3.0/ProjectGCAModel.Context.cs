﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectGCA3._0
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GCAEntities : DbContext
    {
        public GCAEntities()
            : base("name=GCAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_Chaves> tb_Chaves { get; set; }
        public virtual DbSet<tb_Maquinas> tb_Maquinas { get; set; }
        public virtual DbSet<tb_Setores> tb_Setores { get; set; }
        public virtual DbSet<tb_TipoLicenca> tb_TipoLicenca { get; set; }
        public virtual DbSet<tb_Usuarios> tb_Usuarios { get; set; }
    }
}