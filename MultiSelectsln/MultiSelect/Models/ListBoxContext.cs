using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MultiSelect.Models
{
    public partial class ListBoxContext : DbContext
    {
        public ListBoxContext()
        {
        }

        public ListBoxContext(DbContextOptions<ListBoxContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ListBoxDatum> ListBoxData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListBoxDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListBoxDataId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ListBoxData_Id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
