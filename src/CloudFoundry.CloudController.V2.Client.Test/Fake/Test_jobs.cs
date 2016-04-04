//------------------------------------------------------------------------------
// <auto-generated>
  //     This code was generated by a tool.
  //
  //     Changes to this file may cause incorrect behavior and will be lost if
  //     the code is regenerated.
  // </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class JobsEndpoint
{
        [TestMethod]
        public void RetrieveJobThatWasSuccessfulTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""cdd8e42e-6d47-4e37-9d92-94159920bf18"",
    ""created_at"": ""1970-01-01T00:00:00Z"",
    ""url"": ""/v2/jobs/0""
  },
  ""entity"": {
    ""guid"": ""cdd8e42e-6d47-4e37-9d92-94159920bf18"",
    ""status"": ""finished""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobThatWasSuccessful(guid).Result;


                Assert.AreEqual("cdd8e42e-6d47-4e37-9d92-94159920bf18", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("1970-01-01T00:00:00Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/0", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("cdd8e42e-6d47-4e37-9d92-94159920bf18", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("finished", TestUtil.ToTestableString(obj.Status), true);

            }
        }

        [TestMethod]
        public void RetrieveJobWithKnownFailureTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""8b4b1361-ebff-485a-8093-c75f7e844129"",
    ""created_at"": ""2016-03-30T10:15:16Z"",
    ""url"": ""/v2/jobs/5e37621e-0685-4dd9-adec-6903043e1129""
  },
  ""entity"": {
    ""guid"": ""8b4b1361-ebff-485a-8093-c75f7e844129"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""code"": 1001,
      ""description"": ""Request invalid due to parse error: arbitrary string"",
      ""error_code"": ""CF-MessageParseError""
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobWithKnownFailure(guid).Result;


                Assert.AreEqual("8b4b1361-ebff-485a-8093-c75f7e844129", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2016-03-30T10:15:16Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/5e37621e-0685-4dd9-adec-6903043e1129", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("8b4b1361-ebff-485a-8093-c75f7e844129", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
                Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);

            }
        }

        [TestMethod]
        public void RetrieveJobThatIsQueuedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""f001d606-12fc-4ddf-9d4a-18f89b01c44a"",
    ""created_at"": ""2016-03-30T10:15:16Z"",
    ""url"": ""/v2/jobs/5ea45065-89e1-4d27-a9c4-ecce75b61c7e""
  },
  ""entity"": {
    ""guid"": ""f001d606-12fc-4ddf-9d4a-18f89b01c44a"",
    ""status"": ""queued""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobThatIsQueued(guid).Result;


                Assert.AreEqual("f001d606-12fc-4ddf-9d4a-18f89b01c44a", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2016-03-30T10:15:16Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/5ea45065-89e1-4d27-a9c4-ecce75b61c7e", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("f001d606-12fc-4ddf-9d4a-18f89b01c44a", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("queued", TestUtil.ToTestableString(obj.Status), true);

            }
        }

        [TestMethod]
        public void RetrieveJobWithUnknownFailureTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""675487e6-a0ad-4ede-9d15-52384c249059"",
    ""created_at"": ""2016-03-30T10:15:15Z"",
    ""url"": ""/v2/jobs/02a46514-4880-4355-a9b8-1269a9c3356e""
  },
  ""entity"": {
    ""guid"": ""675487e6-a0ad-4ede-9d15-52384c249059"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""error_code"": ""UnknownError"",
      ""description"": ""An unknown error occurred."",
      ""code"": 10001
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobWithUnknownFailure(guid).Result;


                Assert.AreEqual("675487e6-a0ad-4ede-9d15-52384c249059", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2016-03-30T10:15:15Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/02a46514-4880-4355-a9b8-1269a9c3356e", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("675487e6-a0ad-4ede-9d15-52384c249059", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
                Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);

            }
        }

    }
}