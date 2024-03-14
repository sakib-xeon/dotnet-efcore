// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.EntityFrameworkCore.Cosmos.Diagnostics.Internal;
using Microsoft.EntityFrameworkCore.Cosmos.Internal;
using Microsoft.EntityFrameworkCore.TestModels.Northwind;

namespace Microsoft.EntityFrameworkCore.Query;

#nullable disable

public class NorthwindQueryCosmosFixture<TModelCustomizer> : NorthwindQueryFixtureBase<TModelCustomizer>
    where TModelCustomizer : ITestModelCustomizer, new()
{
    protected override ITestStoreFactory TestStoreFactory
        => CosmosNorthwindTestStoreFactory.Instance;

    protected override bool UsePooling
        => false;

    public TestSqlLoggerFactory TestSqlLoggerFactory
        => (TestSqlLoggerFactory)ServiceProvider.GetRequiredService<ILoggerFactory>();

    protected override bool ShouldLogCategory(string logCategory)
        => logCategory == DbLoggerCategory.Query.Name;

    private static readonly string SyncMessage
        = CoreStrings.WarningAsErrorTemplate(
            CosmosEventId.SyncNotSupported.ToString(),
            CosmosResources.LogSyncNotSupported(new TestLogger<CosmosLoggingDefinitions>()).GenerateMessage(),
            "CosmosEventId.SyncNotSupported");

    public async Task NoSyncTest(bool async, Func<bool, Task> testCode)
    {
        try
        {
            await testCode(async);
            Assert.True(async);
        }
        catch (InvalidOperationException e)
        {
            if (e.Message != SyncMessage)
            {
                throw;
            }
            Assert.False(async);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder, DbContext context)
    {
        base.OnModelCreating(modelBuilder, context);

        modelBuilder
            .Entity<CustomerQuery>()
            .HasDiscriminator<string>("Discriminator").HasValue("Customer");

        modelBuilder
            .Entity<OrderQuery>()
            .HasDiscriminator<string>("Discriminator").HasValue("Order");

        modelBuilder
            .Entity<ProductQuery>()
            .HasDiscriminator<string>("Discriminator").HasValue("Product");

        modelBuilder
            .Entity<CustomerQueryWithQueryFilter>()
            .HasDiscriminator<string>("Discriminator").HasValue("Customer");
    }
}
