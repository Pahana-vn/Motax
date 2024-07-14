using System;
using System.Collections.Generic;

namespace Motax.Models;

public partial class Account
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public DateOnly Dob { get; set; }

    public string Gender { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int RoleId { get; set; }

    public virtual ICollection<CommentBlog> CommentBlogs { get; set; } = new List<CommentBlog>();

    public virtual ICollection<Compare> Compares { get; set; } = new List<Compare>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Wishlist> Wishlists { get; set; } = new List<Wishlist>();
}
