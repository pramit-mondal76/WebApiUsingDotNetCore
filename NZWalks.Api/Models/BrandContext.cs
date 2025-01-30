﻿

using Microsoft.EntityFrameworkCore;

namespace NZWalks.Api.Models
{
    public class BrandContext: DbContext
    {
        public BrandContext( DbContextOptions<BrandContext> options) : base(options)
        {
            
        }

        public DbSet<Brand> Brands { get; set; } = null;
    }
}
