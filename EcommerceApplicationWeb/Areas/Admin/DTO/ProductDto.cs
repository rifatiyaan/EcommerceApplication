﻿namespace EcommerceApplicationWeb.Application.DTOs
{
    public class ProductRequestDto
    {
        public string Title { get; set; } = null!;
        public string Code { get; set; } = null!;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int? CategoryId { get; set; }
        public string? ImageUrl { get; set; }
        public ProductMetadataDto Metadata { get; set; } = null!;
        public bool IsActive { get; set; } = true; // 👈 new
    }

    public class ProductResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Code { get; set; } = null!;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int? CategoryId { get; set; }
        public string? ImageUrl { get; set; }
        public ProductMetadataDto Metadata { get; set; } = null!;
        public CategoryResponseDto? Category { get; set; }
        public bool IsActive { get; set; } // 👈 new
    }

    public class ProductMetadataDto
    {
        public string? Description { get; set; }
        public string? Color { get; set; }
        public string? Warranty { get; set; }
    }
}
