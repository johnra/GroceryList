using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GroceryList_DataAccess.GroceryModel
{
    public partial class GroceryContext : DbContext
    {
        public GroceryContext()
        {
        }

        public GroceryContext(DbContextOptions<GroceryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChefLu> ChefLu { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<IngredientCategoryLu> IngredientCategoryLu { get; set; }
        public virtual DbSet<IngredientTypeLu> IngredientTypeLu { get; set; }
        public virtual DbSet<IngredientUnitLu> IngredientUnitLu { get; set; }
        public virtual DbSet<LinkMealRecipe> LinkMealRecipe { get; set; }
        public virtual DbSet<LinkRecipeAttribute> LinkRecipeAttribute { get; set; }
        public virtual DbSet<LinkRecipeIngredient> LinkRecipeIngredient { get; set; }
        public virtual DbSet<Meal> Meal { get; set; }
        public virtual DbSet<MealCategoryLu> MealCategoryLu { get; set; }
        public virtual DbSet<MealTypeLu> MealTypeLu { get; set; }
        public virtual DbSet<Recipe> Recipe { get; set; }
        public virtual DbSet<RecipeAttributeLu> RecipeAttributeLu { get; set; }
        public virtual DbSet<RecipeCategoryLu> RecipeCategoryLu { get; set; }
        public virtual DbSet<RecipeTypeLu> RecipeTypeLu { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SqlExpress;Database=DB_Grocery;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChefLu>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Reference).IsUnicode(false);
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.DefaultUnit)
                    .WithMany(p => p.Ingredient)
                    .HasForeignKey(d => d.DefaultUnitId)
                    .HasConstraintName("FK_Ingredient_IngredientUnitLu");

                entity.HasOne(d => d.IngredientCategory)
                    .WithMany(p => p.Ingredient)
                    .HasForeignKey(d => d.IngredientCategoryId)
                    .HasConstraintName("FK_Ingredient_IngredientCategoryLu");

                entity.HasOne(d => d.IngredientType)
                    .WithMany(p => p.Ingredient)
                    .HasForeignKey(d => d.IngredientTypeId)
                    .HasConstraintName("FK_Ingredient_Ingredient");
            });

            modelBuilder.Entity<IngredientCategoryLu>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<IngredientTypeLu>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<IngredientUnitLu>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<LinkMealRecipe>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.LinkMealRecipe)
                    .HasForeignKey(d => d.MealId)
                    .HasConstraintName("FK_LinkMealRecipe_Meal");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.LinkMealRecipe)
                    .HasForeignKey(d => d.RecipeId)
                    .HasConstraintName("FK_LinkMealRecipe_Recipe");
            });

            modelBuilder.Entity<LinkRecipeAttribute>(entity =>
            {
                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.LinkRecipeAttribute)
                    .HasForeignKey(d => d.AttributeId)
                    .HasConstraintName("FK_LinkRecipeAttribute_RecipeAttributeLu");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.LinkRecipeAttribute)
                    .HasForeignKey(d => d.RecipeId)
                    .HasConstraintName("FK_LinkRecipeAttribute_Recipe");
            });

            modelBuilder.Entity<LinkRecipeIngredient>(entity =>
            {
                entity.Property(e => e.Size).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.LinkRecipeIngredient)
                    .HasForeignKey(d => d.IngredientId)
                    .HasConstraintName("FK_LinkRecipeIngredient_Ingredient");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.LinkRecipeIngredient)
                    .HasForeignKey(d => d.RecipeId)
                    .HasConstraintName("FK_LinkRecipeIngredient_Recipe");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.LinkRecipeIngredient)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_LinkRecipeIngredient_IngredientUnitLu");
            });

            modelBuilder.Entity<Meal>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.MealCategory)
                    .WithMany(p => p.Meal)
                    .HasForeignKey(d => d.MealCategoryId)
                    .HasConstraintName("FK_Meal_MealCategoryLu");

                entity.HasOne(d => d.MealType)
                    .WithMany(p => p.Meal)
                    .HasForeignKey(d => d.MealTypeId)
                    .HasConstraintName("FK_Meal_MealTypeLu");
            });

            modelBuilder.Entity<MealCategoryLu>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<MealTypeLu>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Link).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Reference).IsUnicode(false);

                entity.HasOne(d => d.RecipeCategory)
                    .WithMany(p => p.Recipe)
                    .HasForeignKey(d => d.RecipeCategoryId)
                    .HasConstraintName("FK_Recipe_RecipeCategoryLu");

                entity.HasOne(d => d.RecipeType)
                    .WithMany(p => p.Recipe)
                    .HasForeignKey(d => d.RecipeTypeId)
                    .HasConstraintName("FK_Recipe_RecipeTypeLu");
            });

            modelBuilder.Entity<RecipeAttributeLu>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<RecipeCategoryLu>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<RecipeTypeLu>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Username).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
