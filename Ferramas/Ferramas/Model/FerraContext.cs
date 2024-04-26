using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ferramas.Model;

public sealed class FerraContext : DbContext
{
    public FerraContext(DbContextOptions<FerraContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        Keys(modelBuilder);
        Seed(modelBuilder);
    }

    private void Keys(ModelBuilder builder)
    {
        IEnumerable<IMutableForeignKey> foreignKeys = builder
            .Model
            .GetEntityTypes()
            .SelectMany(k => k.GetForeignKeys());

        foreach (IMutableForeignKey key in foreignKeys)
            key.DeleteBehavior = DeleteBehavior.NoAction;
    }

    private void Seed(ModelBuilder builder)
    {

    }
}
