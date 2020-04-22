using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GroceryList
{
    public partial class RecipeContext : DbContext
    {
        public RecipeContext()
        {
        }

        public RecipeContext(DbContextOptions<RecipeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<IngredientCategory> IngredientCategory { get; set; }
        public virtual DbSet<IngredientSource> IngredientSource { get; set; }
        public virtual DbSet<Meal> Meal { get; set; }
        public virtual DbSet<Recipe> Recipe { get; set; }
        public virtual DbSet<RecipeCategory> RecipeCategory { get; set; }
        public virtual DbSet<RecipeChef> RecipeChef { get; set; }
        public virtual DbSet<RecipeIngredient> RecipeIngredient { get; set; }
        public virtual DbSet<RecipeType> RecipeType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SqlExpress;Database=DB_Recipe;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Ingredient)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Ingredient_IngredientCategory");
            });

            modelBuilder.Entity<IngredientCategory>(entity =>
            {
                entity.Property(e => e.Name).IsFixedLength();
            });

            modelBuilder.Entity<IngredientSource>(entity =>
            {
                entity.Property(e => e.LocalAddress1).IsUnicode(false);

                entity.Property(e => e.LocalAddress2).IsUnicode(false);

                entity.Property(e => e.LocalCity).IsUnicode(false);

                entity.Property(e => e.LocalEmail).IsUnicode(false);

                entity.Property(e => e.LocalPhone).IsUnicode(false);

                entity.Property(e => e.LocalState).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.OnlineAddress1).IsUnicode(false);

                entity.Property(e => e.RegionalAddress1).IsUnicode(false);

                entity.Property(e => e.RegionalAddress2).IsUnicode(false);

                entity.Property(e => e.RegionalCity).IsUnicode(false);

                entity.Property(e => e.RegionalEmail).IsUnicode(false);

                entity.Property(e => e.RegionalPhone).IsUnicode(false);

                entity.Property(e => e.RegionalState).IsUnicode(false);
            });

            modelBuilder.Entity<Meal>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PrepTime).HasDefaultValueSql("((30))");

                entity.Property(e => e.Reference).IsUnicode(false);

                entity.Property(e => e.Servings).HasDefaultValueSql("((2))");

                entity.Property(e => e.Stars).HasDefaultValueSql("((3))");

                entity.HasOne(d => d.RecipeCategory)
                    .WithMany(p => p.Recipe)
                    .HasForeignKey(d => d.RecipeCategoryId)
                    .HasConstraintName("FK_Recipe_RecipeCategory");

                entity.HasOne(d => d.RecipeChef)
                    .WithMany(p => p.Recipe)
                    .HasForeignKey(d => d.RecipeChefId)
                    .HasConstraintName("FK_Recipe_RecipeChef");

                entity.HasOne(d => d.RecipeType)
                    .WithMany(p => p.Recipe)
                    .HasForeignKey(d => d.RecipeTypeId)
                    .HasConstraintName("FK_Recipe_RecipeType");
            });

            modelBuilder.Entity<RecipeCategory>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<RecipeChef>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<RecipeIngredient>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Size).IsUnicode(false);

                entity.HasOne(d => d.Ingredient)
                    .WithMany()
                    .HasForeignKey(d => d.IngredientId)
                    .HasConstraintName("FK_RecipeIngredient_Ingredient");

                entity.HasOne(d => d.Recipe)
                    .WithMany()
                    .HasForeignKey(d => d.RecipeId)
                    .HasConstraintName("FK_RecipeIngredient_Recipe");
            });

            modelBuilder.Entity<RecipeType>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
