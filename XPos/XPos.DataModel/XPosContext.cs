namespace XPos.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class XPosContext : DbContext
    {
        public XPosContext()
            : base("name=XPosContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<FileCollection> FileCollections { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderHeader> OrderHeaders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Variant> Variants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.Initial)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.ModifyBy)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Variants)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FileCollection>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<FileCollection>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<FileCollection>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<FileCollection>()
                .Property(e => e.ModifyBy)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.ModifyBy)
                .IsUnicode(false);

            modelBuilder.Entity<OrderHeader>()
                .Property(e => e.Reference)
                .IsUnicode(false);

            modelBuilder.Entity<OrderHeader>()
                .Property(e => e.Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderHeader>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<OrderHeader>()
                .Property(e => e.ModifyBy)
                .IsUnicode(false);

            modelBuilder.Entity<OrderHeader>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.OrderHeader)
                .HasForeignKey(e => e.HeaderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Initial)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.Stock)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ModifyBy)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Variant>()
                .Property(e => e.Initial)
                .IsUnicode(false);

            modelBuilder.Entity<Variant>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Variant>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Variant>()
                .Property(e => e.ModifyBy)
                .IsUnicode(false);

            modelBuilder.Entity<Variant>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Variant)
                .WillCascadeOnDelete(false);
        }
    }
}
