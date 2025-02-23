using FluentMigrator.Runner;
using Microsoft.EntityFrameworkCore;

namespace NxT.Infrastructure.Data.Providers;

public interface IDbProvider
{
    public void Configure(DbContextOptionsBuilder options);
    public IMigrationRunnerBuilder Migrate(IMigrationRunnerBuilder builder);
}