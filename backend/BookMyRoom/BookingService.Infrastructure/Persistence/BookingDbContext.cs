using BookingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookingService.Infrastructure.Persistence;

public class BookingDbContext : DbContext
{
    public BookingDbContext(DbContextOptions<BookingDbContext> options) : base(options)
    {
    }

    public DbSet<Booking> Bookings { get; set; }
    public DbSet<BookingGroup> BookingGroups { get; set; }
    public DbSet<BookingGroupAmount> BookingGroupAmounts { get; set; }
    public DbSet<BookingGroupAmountCoupon> BookingGroupAmountCoupons { get; set; }
    public DbSet<BookingGroupHistory> BookingGroupHistories { get; set; }
    public DbSet<BookingGuest> BookingGuests { get; set; }
    public DbSet<Coupon> Coupons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookingDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}

