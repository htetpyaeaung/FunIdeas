﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment1.Net.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FunIdeasEntities : DbContext
    {
        public FunIdeasEntities()
            : base("name=FunIdeasEntities")
        {
            Categories = Set<Category>();
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        internal virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Idea> Ideas { get; set; }
        public virtual DbSet<Image> Images { get; set; }
    }
}