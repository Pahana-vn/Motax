using System;
using System.Collections.Generic;

namespace Motax.Models;

public partial class Order
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int StaffId { get; set; }

    public string OrderCode { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime DeliveryDate { get; set; }

    public string Username { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string HowToPay { get; set; } = null!;

    public string HowToTransport { get; set; } = null!;

    public double TransportFee { get; set; }

    public int Status { get; set; }

    public string Note { get; set; } = null!;

    public DateTime CreateDay { get; set; }

    public DateTime UpdateDay { get; set; }

    public double TotalAmount { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
