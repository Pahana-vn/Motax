using System;
using System.Collections.Generic;

namespace Motax.Models;

public partial class Brand
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string ContactPerson { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public string Image { get; set; } = null!;

    public int Status { get; set; }

    public virtual ICollection<Accessory> Accessories { get; set; } = new List<Accessory>();

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
