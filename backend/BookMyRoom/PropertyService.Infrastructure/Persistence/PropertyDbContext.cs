using Microsoft.EntityFrameworkCore;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence;

public class PropertyDbContext : DbContext
{
    public PropertyDbContext(DbContextOptions<PropertyDbContext> options) : base(options)
    {
    }

    public DbSet<Property> Properties { get; set; }
    public DbSet<PropertyAddress> PropertyAddresses { get; set; }
    public DbSet<PropertyFeatured> PropertyFeatures { get; set; }
    public DbSet<PropertyLocation> PropertyLocations { get; set; }
    public DbSet<PropertyPhoto> PropertyPhotos { get; set; }
    public DbSet<PropertyRule> PropertyRules { get; set; }
    public DbSet<PropertyStars> PropertyStars { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<RoomAmenity> RoomAmenities { get; set; }
    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<RoomTypeBasicFacility> RoomTypeBasicFacilities { get; set; }
    public DbSet<RoomTypeDiscount> RoomTypeDiscounts { get; set; }
    public DbSet<RoomTypeFoodFacility> RoomTypeFoodFacilities { get; set; }
    public DbSet<RoomTypeOtherFacility> RoomTypeOtherFacilities { get; set; }
    public DbSet<RoomTypePhoto> RoomTypePhotos { get; set; }
    public DbSet<RoomTypeReview> RoomTypeReviews { get; set; }
    public DbSet<RoomTypeReviewPhoto> RoomTypeReviewPhotos { get; set; }
    public DbSet<RoomTypeSecurityFacility> RoomTypeSecurityFacilities { get; set; }
    public DbSet<RoomTypeStaffService> RoomTypeStaffServices { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PropertyDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}