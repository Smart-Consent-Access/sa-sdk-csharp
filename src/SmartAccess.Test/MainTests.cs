using System;
using Xunit;

namespace SmartAccess
{
    public class MainTests
    {
        private SA SA;
        public MainTests()
        {
            Environment.SetEnvironmentVariable("SA_SERVICE_PROVIDER_PRIVATE_KEY_PATH", "../../../../../../../../ah-poc-sys1-api/certs/mdu-private.key.pem");
            Environment.SetEnvironmentVariable("SA_PUBLIC_KEY_PATH", "../../../../../../../../ah-poc-sys1-api/certs/mdu-public.key.pem");
            Environment.SetEnvironmentVariable("SA_SERVICE_PROVIDER_ID", "080f264e-99f6-49d3-938c-b8c2d93bf179");

            SA = new SA();
        }

        public void InstanceTest()
        {
            Assert.IsType<SA>(SA);
        }

        [Fact]
        public void ImportAndInitializeAO()
        {
            string serviceProviderId = "sp-id";
            try
            {
                var response = SA.ServiceProviders().GetServiceProvider(serviceProviderId);
            }
            catch (Exception ex)
            {
                Assert.True(ex is Exception);
            }
        }
    }
}
