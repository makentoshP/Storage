using Microsoft.Extensions.DependencyInjection;
using Testcontainers.FakeGcsServer;
using Xunit;

namespace ManagedCode.Storage.Tests.Storages.GCS;


public class GCSUploadTests : UploadTests<FakeGcsServerContainer>
{
    protected override FakeGcsServerContainer Build()
    {
        return new FakeGcsServerBuilder().Build();
    }

    protected override ServiceProvider ConfigureServices()
    {
        return GCSConfigurator.ConfigureServices(Container.GetConnectionString());
    }
}