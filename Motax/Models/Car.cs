using System;
using System.Collections.Generic;

namespace Motax.Models;

public partial class Car
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string BodyType { get; set; } = null!;

    public string Condition { get; set; } = null!;

    public string? Mileage { get; set; }

    public string Transmission { get; set; } = null!;

    public int Year { get; set; }

    public string FuelType { get; set; } = null!;

    public string ImageSingle { get; set; } = null!;

    public string ImageMultiple { get; set; } = null!;

    public string Color { get; set; } = null!;

    public int Doors { get; set; }

    public int Cylinders { get; set; }

    public string EngineSize { get; set; } = null!;

    public string Vin { get; set; } = null!;

    public string CarFeatures { get; set; } = null!;

    public string Title { get; set; } = null!;

    public int BrandId { get; set; }

    public int CategoryId { get; set; }

    public double Price { get; set; }

    public string PriceType { get; set; } = null!;

    public string ViewLuot { get; set; } = null!;

    public string DriverAirbag { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateOnly? StarDay { get; set; }

    public DateOnly? UpdateDay { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Compare> Compares { get; set; } = new List<Compare>();

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<Wishlist> Wishlists { get; set; } = new List<Wishlist>();
}
