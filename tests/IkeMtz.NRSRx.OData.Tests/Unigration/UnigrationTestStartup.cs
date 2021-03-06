using IkeMtz.NRSRx.Core.Unigration;
using IkeMtz.Samples.OData;
using IkeMtz.Samples.OData.Configuration;
using IkeMtz.Samples.OData.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IkeMtz.NRSRx.OData.Tests
{
  public class UnigrationTestStartup
     : CoreODataUnigrationTestStartup<Startup, ModelConfiguration>
  {
    public UnigrationTestStartup(IConfiguration configuration) : base(new Startup(configuration))
    {
    }
    public override void SetupAuthentication(AuthenticationBuilder builder)
    {
      builder.SetupTestAuthentication(Configuration, TestContext);
    }
    public override void SetupDatabase(IServiceCollection services, string connectionString)
    {
      services.SetupTestDbContext<DatabaseContext>();
    }
  }
}
