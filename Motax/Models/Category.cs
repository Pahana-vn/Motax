using System;
using System.Collections.Generic;

namespace Motax.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public int Status { get; set; }

    public DateOnly StarDay { get; set; }

    public DateOnly UpdateDay { get; set; }

    public virtual ICollection<Accessory> Accessories { get; set; } = new List<Accessory>();

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
