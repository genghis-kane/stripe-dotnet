namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeFileUploadTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/files/file_123");
            var fileUpload = Mapper<StripeFileUpload>.MapFromJson(json);
            Assert.NotNull(fileUpload);
            Assert.IsType<StripeFileUpload>(fileUpload);
            Assert.NotNull(fileUpload.Id);
            Assert.Equal("file_upload", fileUpload.Object);
        }
    }
}
