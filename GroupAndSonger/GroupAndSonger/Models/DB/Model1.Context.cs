﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GroupAndSonger.Models.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class subdcursa4Entities : DbContext
    {
        public subdcursa4Entities()
            : base("name=subdcursa4Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<authors> authors { get; set; }
        public virtual DbSet<buy_tick> buy_tick { get; set; }
        public virtual DbSet<country> country { get; set; }
        public virtual DbSet<executor> executor { get; set; }
        public virtual DbSet<group_executor> group_executor { get; set; }
        public virtual DbSet<groups> groups { get; set; }
        public virtual DbSet<places> places { get; set; }
        public virtual DbSet<repertoires> repertoires { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<songs> songs { get; set; }
        public virtual DbSet<tour_songs> tour_songs { get; set; }
        public virtual DbSet<tours> tours { get; set; }
        public virtual DbSet<users> users { get; set; }
    }
}