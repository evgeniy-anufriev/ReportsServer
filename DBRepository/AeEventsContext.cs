using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace DBRepository
{
    public partial class AeEventContext : DbContext
    {
        public AeEventContext( DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Models.Models.Attribute> Attribute { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Condition> Condition { get; set; }
        public virtual DbSet<EventHistory> EventHistory { get; set; }
        public virtual DbSet<SubCondition> SubCondition { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Models.Attribute>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Attribute)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Attribute_Category");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.DataSourceAlias)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Condition>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Condition)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Condition_Category");
            });

            modelBuilder.Entity<EventHistory>(entity =>
            {
                entity.HasKey(e => new { e.EventTime, e.Id });

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ActiveTime).HasColumnType("datetime");

                entity.Property(e => e.ActorId)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Attrib00Id).HasColumnName("Attrib00_Id");

                //entity.Property(e => e.Attrib01Id).HasColumnName("Attrib01_Id");

                //entity.Property(e => e.Attrib02Id).HasColumnName("Attrib02_Id");

                //entity.Property(e => e.Attrib03Id).HasColumnName("Attrib03_Id");

                //entity.Property(e => e.Attrib04Id).HasColumnName("Attrib04_Id");

                //entity.Property(e => e.Attrib05Id).HasColumnName("Attrib05_Id");

                //entity.Property(e => e.Attrib06Id).HasColumnName("Attrib06_Id");

                //entity.Property(e => e.Attrib07Id).HasColumnName("Attrib07_Id");

                //entity.Property(e => e.Attrib08Id).HasColumnName("Attrib08_Id");

                //entity.Property(e => e.Attrib09Id).HasColumnName("Attrib09_Id");

                //entity.Property(e => e.Attrib10Id).HasColumnName("Attrib10_Id");

                //entity.Property(e => e.Attrib11Id).HasColumnName("Attrib11_Id");

                //entity.Property(e => e.Attrib12Id).HasColumnName("Attrib12_Id");

                //entity.Property(e => e.Attrib13Id).HasColumnName("Attrib13_Id");

                //entity.Property(e => e.Attrib14Id).HasColumnName("Attrib14_Id");

                //entity.Property(e => e.Attrib15Id).HasColumnName("Attrib15_Id");

                //entity.Property(e => e.Attrib16Id).HasColumnName("Attrib16_Id");

                //entity.Property(e => e.Attrib17Id).HasColumnName("Attrib17_Id");

                //entity.Property(e => e.Attrib18Id).HasColumnName("Attrib18_Id");

                //entity.Property(e => e.Attrib19Id).HasColumnName("Attrib19_Id");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubCondition>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Condition)
                    .WithMany(p => p.SubCondition)
                    .HasForeignKey(d => d.ConditionId)
                    .HasConstraintName("FK_SubCondition_Condition");
            });
        }
    }
}
