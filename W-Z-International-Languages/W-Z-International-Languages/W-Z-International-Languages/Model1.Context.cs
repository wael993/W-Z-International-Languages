﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace W_Z_International_Languages
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class W_Z_International_LanguagesEntities31 : DbContext
    {
        public W_Z_International_LanguagesEntities31()
            : base("name=W_Z_International_LanguagesEntities31")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<course> course { get; set; }
        public virtual DbSet<course_student> course_student { get; set; }
        public virtual DbSet<student> student { get; set; }
    }
}
