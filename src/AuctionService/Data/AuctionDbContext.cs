using System;
using AuctiononService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctiononService.Data;

public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions<AuctionDbContext> options) : base(options)
    {
    }

    public DbSet<Auction> Auctions { get; set; }
}
