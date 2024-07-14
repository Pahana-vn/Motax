using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Motax.Models;

public partial class MotaxContext : DbContext
{
    public MotaxContext()
    {
    }

    public MotaxContext(DbContextOptions<MotaxContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Accessory> Accessories { get; set; }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<BlogDetail> BlogDetails { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<CommentBlog> CommentBlogs { get; set; }

    public virtual DbSet<Compare> Compares { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Dealer> Dealers { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    public virtual DbSet<Wishlist> Wishlists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-0QD3R2K;Initial Catalog=Motax;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accessory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Accessor__3214EC075D5B15C2");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.EndDay).HasColumnType("datetime");
            entity.Property(e => e.ImageSingle).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Slug).HasMaxLength(255);
            entity.Property(e => e.StartDay).HasColumnType("datetime");
            entity.Property(e => e.TypeCode).HasMaxLength(50);

            entity.HasOne(d => d.Brand).WithMany(p => p.Accessories)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Accessori__Brand__47DBAE45");

            entity.HasOne(d => d.Category).WithMany(p => p.Accessories)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Accessori__Categ__48CFD27E");
        });

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Accounts__3214EC07B9676DDA");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasOne(d => d.Role).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Accounts__RoleId__398D8EEE");
        });

        modelBuilder.Entity<Blog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Blogs__3214EC07205DB48C");

            entity.Property(e => e.ImageSingle).HasMaxLength(255);
            entity.Property(e => e.Summary).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<BlogDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BlogDeta__3214EC0761393CEA");

            entity.HasOne(d => d.Blog).WithMany(p => p.BlogDetails)
                .HasForeignKey(d => d.BlogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BlogDetai__BlogI__6B24EA82");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Brands__3214EC072CBA3152");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.ContactPerson).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Image).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.Slug).HasMaxLength(255);
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cars__3214EC0768227BEF");

            entity.Property(e => e.BodyType).HasMaxLength(50);
            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.Condition).HasMaxLength(50);
            entity.Property(e => e.DriverAirbag).HasMaxLength(50);
            entity.Property(e => e.EngineSize).HasMaxLength(50);
            entity.Property(e => e.FuelType).HasMaxLength(50);
            entity.Property(e => e.ImageSingle).HasMaxLength(255);
            entity.Property(e => e.Mileage).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PriceType).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Transmission).HasMaxLength(50);
            entity.Property(e => e.ViewLuot).HasMaxLength(255);
            entity.Property(e => e.Vin)
                .HasMaxLength(50)
                .HasColumnName("VIN");

            entity.HasOne(d => d.Brand).WithMany(p => p.Cars)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Cars__BrandId__440B1D61");

            entity.HasOne(d => d.Category).WithMany(p => p.Cars)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Cars__CategoryId__44FF419A");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC07860EBD0D");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Image).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Slug).HasMaxLength(255);
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comment__3214EC073C6FCA3C");

            entity.ToTable("Comment");

            entity.Property(e => e.Comment1).HasColumnName("Comment");
            entity.Property(e => e.CommentDate).HasColumnType("datetime");

            entity.HasOne(d => d.Accessories).WithMany(p => p.Comments)
                .HasForeignKey(d => d.AccessoriesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comment__Accesso__59063A47");

            entity.HasOne(d => d.Car).WithMany(p => p.Comments)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comment__CarId__5812160E");

            entity.HasOne(d => d.Customer).WithMany(p => p.Comments)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comment__Custome__59FA5E80");
        });

        modelBuilder.Entity<CommentBlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CommentB__3214EC0739447B22");

            entity.Property(e => e.CommentDate).HasColumnType("datetime");

            entity.HasOne(d => d.Blog).WithMany(p => p.CommentBlogs)
                .HasForeignKey(d => d.BlogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CommentBl__BlogI__6E01572D");

            entity.HasOne(d => d.User).WithMany(p => p.CommentBlogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CommentBl__UserI__6EF57B66");
        });

        modelBuilder.Entity<Compare>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Compares__3214EC07BAFA3DB1");

            entity.Property(e => e.CompareDate).HasColumnType("datetime");

            entity.HasOne(d => d.Car).WithMany(p => p.Compares)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Compares__CarId__5DCAEF64");

            entity.HasOne(d => d.User).WithMany(p => p.Compares)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Compares__UserId__5CD6CB2B");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC07A4A5A093");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
        });

        modelBuilder.Entity<Dealer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Dealers__3214EC07D03F0EBC");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Discount__3214EC073CC7330B");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Inventor__3214EC076895F69F");

            entity.ToTable("Inventory");

            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.WarehouseLocation).HasMaxLength(255);

            entity.HasOne(d => d.Accessories).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.AccessoriesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inventory__Acces__4D94879B");

            entity.HasOne(d => d.Car).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inventory__CarId__4CA06362");

            entity.HasOne(d => d.Dealer).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.DealerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inventory__Deale__4BAC3F29");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Orders__3214EC0742B69509");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.CreateDay).HasColumnType("datetime");
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.HowToPay).HasMaxLength(255);
            entity.Property(e => e.HowToTransport).HasMaxLength(255);
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.OrderCode).HasMaxLength(255);
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.UpdateDay).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(255);

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Orders__Customer__5070F446");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderDet__3214EC07E11AACD8");

            entity.HasOne(d => d.Accessories).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.AccessoriesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderDeta__Acces__5535A963");

            entity.HasOne(d => d.Car).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderDeta__CarId__5441852A");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderDeta__Order__534D60F1");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC0724142291");

            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Value).HasMaxLength(255);
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Vouchers__3214EC072B5864EA");

            entity.Property(e => e.VoucherCode).HasMaxLength(50);
        });

        modelBuilder.Entity<Wishlist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Wishlist__3214EC07029E9C0B");

            entity.ToTable("Wishlist");

            entity.Property(e => e.SelectDate).HasColumnType("datetime");

            entity.HasOne(d => d.Accessories).WithMany(p => p.Wishlists)
                .HasForeignKey(d => d.AccessoriesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Wishlist__Access__66603565");

            entity.HasOne(d => d.Car).WithMany(p => p.Wishlists)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Wishlist__CarId__656C112C");

            entity.HasOne(d => d.User).WithMany(p => p.Wishlists)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Wishlist__UserId__6477ECF3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
