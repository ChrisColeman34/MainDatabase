using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccessCore
{
    public partial class MaindbContext : DbContext
    {
        public virtual DbSet<CoreObjectMetadata> CoreObjectMetadata { get; set; }
        public virtual DbSet<CoreObjects> CoreObjects { get; set; }
        public virtual DbSet<CoreObjectTypes> CoreObjectTypes { get; set; }
        public virtual DbSet<CoreRelationships> CoreRelationships { get; set; }
        public virtual DbSet<MetadataType> MetadataType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // TODO - Move
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=MainDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoreObjectMetadata>(entity =>
            {
                entity.HasIndex(e => e.Id);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Metadata)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => (MetadataType)d.MetadataTypeNavigation)
                    .WithMany(p => (ICollection<CoreObjectMetadata>)p.CoreObjectMetadata)
                    .HasForeignKey(d => d.MetadataType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoreObjectMetadata_MetadataType");
            });

            modelBuilder.Entity<CoreObjects>(entity =>
            {
                entity.HasIndex(e => e.Id);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasDefaultValueSql(" ");

                entity.HasOne(d => (CoreObjectMetadata)d.ObjectMetadata)
                    .WithMany(p => (ICollection<CoreObjects>)p.CoreObjects)
                    .HasForeignKey(d => d.ObjectMetadataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoreObjects_CoreObjectMetaData");

                entity.HasOne(d => (CoreObjectTypes)d.ObjectType)
                    .WithMany(p => (ICollection<CoreObjects>)p.CoreObjects)
                    .HasForeignKey(d => d.ObjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoreObjects_CoreObjectType");
            });

            modelBuilder.Entity<CoreObjectTypes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ObjectTypeName)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<CoreRelationships>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => (CoreObjectMetadata)d.Metadata)
                    .WithMany(p => (ICollection<CoreRelationships>)p.CoreRelationships)
                    .HasForeignKey(d => d.MetadataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoreRelationships_Metadata");

                entity.HasOne(d => (CoreObjects)d.ObjectIdNodeOneNavigation)
                    .WithMany(p => (ICollection<CoreRelationships>)p.CoreRelationshipsObjectIdNodeOneNavigation)
                    .HasForeignKey(d => d.ObjectIdNodeOne)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoreRelationships_CoreObjectsFirstObject");

                entity.HasOne(d => (CoreObjects)d.ObjectIdNodeTwoNavigation)
                    .WithMany(p => (ICollection<CoreRelationships>)p.CoreRelationshipsObjectIdNodeTwoNavigation)
                    .HasForeignKey(d => d.ObjectIdNodeTwo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoreRelationships_CoreObjectsSecondObject");
            });

            modelBuilder.Entity<MetadataType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });
        }
    }
}
