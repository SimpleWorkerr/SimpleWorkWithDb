﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabWork_8_1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TestWorkDBEntities : DbContext
    {
        public TestWorkDBEntities()
            : base("name=TestWorkDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Договоры> Договоры { get; set; }
        public virtual DbSet<Поставлено> Поставлено { get; set; }
        public virtual DbSet<Поставщики> Поставщики { get; set; }
        public virtual DbSet<ФизическиеЛица> ФизическиеЛица { get; set; }
        public virtual DbSet<ЮридическиеЛица> ЮридическиеЛица { get; set; }
    }
}
