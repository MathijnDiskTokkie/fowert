﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Flowerpower.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FlowerpowerEntities : DbContext
    {
        public FlowerpowerEntities()
            : base("name=FlowerpowerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<bestelling> bestelling { get; set; }
        public virtual DbSet<klant> klant { get; set; }
        public virtual DbSet<medewerkers> medewerkers { get; set; }
        public virtual DbSet<producten> producten { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<winkel> winkel { get; set; }
        public virtual DbSet<winkelmand> winkelmand { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    }
}
