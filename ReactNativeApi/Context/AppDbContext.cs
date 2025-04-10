using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReactNativeApi.Models;
using System.Text.Json;

namespace ReactNativeApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }

    public DbSet<TableOne> TableOnes => Set<TableOne>();
    public DbSet<TableTwo> TableTwos => Set<TableTwo>();
    public DbSet<TableThree> TableThrees => Set<TableThree>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var listToStringConverter = new ValueConverter<List<string>, string>(
            v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
            v => JsonSerializer.Deserialize<List<string>>(v, new JsonSerializerOptions())
        );

        modelBuilder.Entity<TableTwo>()
            .Property(e => e.AciklamaListesi)
            .HasConversion(listToStringConverter);

        modelBuilder.Entity<TableThree>()
            .HasMany(x => x.UygunsuzlukTespitListesi)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);
    }
}

