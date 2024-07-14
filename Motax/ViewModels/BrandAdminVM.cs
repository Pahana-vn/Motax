namespace Motax.ViewModels
{
    public class BrandAdminVM
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string ContactPerson { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string? Slug { get; set; }

        public IFormFile? Image { get; set; } = null!;

        public int Status { get; set; }
        public string? ExistingImage { get; set; }
    }
}
