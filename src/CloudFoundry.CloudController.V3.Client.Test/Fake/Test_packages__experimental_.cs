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

using CloudFoundry.CloudController.V3.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V3.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class PackagesExperimentalEndpoint
{
        [TestMethod]
        public void CreatePackageTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""guid"": ""99ff3cf1-0c68-4c0e-a246-f1b46401c7e3"",
  ""type"": ""docker"",
  ""data"": {
    ""image"": ""registry/image:latest""
  },
  ""state"": ""READY"",
  ""created_at"": ""2016-03-30T10:15:14Z"",
  ""updated_at"": null,
  ""links"": {
    ""self"": {
      ""href"": ""/v3/packages/b6c16bf5-cab9-444f-b4fb-f326734a5438""
    },
    ""stage"": {
      ""href"": ""/v3/packages/b6c16bf5-cab9-444f-b4fb-f326734a5438/droplets"",
      ""method"": ""POST""
    },
    ""app"": {
      ""href"": ""/v3/apps/dece0071-1236-40b0-8672-0031cefe78e0""
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                CreatePackageRequest value = new CreatePackageRequest();


                var obj = cfClient.PackagesExperimental.CreatePackage(guid, value).Result;


                Assert.AreEqual("99ff3cf1-0c68-4c0e-a246-f1b46401c7e3", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("docker", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("READY", TestUtil.ToTestableString(obj.State), true);
                Assert.AreEqual("2016-03-30T10:15:14Z", TestUtil.ToTestableString(obj.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.UpdatedAt), true);

            }
        }

        [TestMethod]
        public void GetPackageTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""guid"": ""c9086031-d485-4e0a-a36a-c728ae77ad51"",
  ""type"": ""bits"",
  ""data"": {
    ""error"": null,
    ""hash"": {
      ""type"": ""sha1"",
      ""value"": null
    }
  },
  ""state"": ""AWAITING_UPLOAD"",
  ""created_at"": ""2016-03-30T10:15:15Z"",
  ""updated_at"": null,
  ""links"": {
    ""self"": {
      ""href"": ""/v3/packages/fb19b59b-5036-44e8-b5a4-8a452b8c6355""
    },
    ""upload"": {
      ""href"": ""/v3/packages/fb19b59b-5036-44e8-b5a4-8a452b8c6355/upload"",
      ""method"": ""POST""
    },
    ""download"": {
      ""href"": ""/v3/packages/fb19b59b-5036-44e8-b5a4-8a452b8c6355/download"",
      ""method"": ""GET""
    },
    ""stage"": {
      ""href"": ""/v3/packages/fb19b59b-5036-44e8-b5a4-8a452b8c6355/droplets"",
      ""method"": ""POST""
    },
    ""app"": {
      ""href"": ""/v3/apps/9311cb97-2df3-4b3e-b2d9-459ff7f81d70""
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.PackagesExperimental.GetPackage(guid).Result;


                Assert.AreEqual("c9086031-d485-4e0a-a36a-c728ae77ad51", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("bits", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("AWAITING_UPLOAD", TestUtil.ToTestableString(obj.State), true);
                Assert.AreEqual("2016-03-30T10:15:15Z", TestUtil.ToTestableString(obj.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.UpdatedAt), true);

            }
        }

        [TestMethod]
        public void CopyPackageTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""guid"": ""de7c8a78-0c0b-4925-8cfb-1ecdab28af2c"",
  ""type"": ""docker"",
  ""data"": {
    ""image"": ""http://awesome-sauce.com""
  },
  ""state"": ""READY"",
  ""created_at"": ""2016-03-30T10:15:14Z"",
  ""updated_at"": null,
  ""links"": {
    ""self"": {
      ""href"": ""/v3/packages/8908a7d5-eb28-4f5d-9b64-82e367e51140""
    },
    ""stage"": {
      ""href"": ""/v3/packages/8908a7d5-eb28-4f5d-9b64-82e367e51140/droplets"",
      ""method"": ""POST""
    },
    ""app"": {
      ""href"": ""/v3/apps/d0d30db4-c403-4124-a44c-6098ab6784f3""
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.PackagesExperimental.CopyPackage(guid).Result;


                Assert.AreEqual("de7c8a78-0c0b-4925-8cfb-1ecdab28af2c", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("docker", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("READY", TestUtil.ToTestableString(obj.State), true);
                Assert.AreEqual("2016-03-30T10:15:14Z", TestUtil.ToTestableString(obj.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.UpdatedAt), true);

            }
        }

        [TestMethod]
        public void ListAssociatedPackagesTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""pagination"": {
    ""total_results"": 1,
    ""first"": {
      ""href"": ""/v3/apps/79ad15e1-bf92-41fd-b4dc-e52ab03c1628/packages?page=1=50""
    },
    ""last"": {
      ""href"": ""/v3/apps/79ad15e1-bf92-41fd-b4dc-e52ab03c1628/packages?page=1=50""
    },
    ""next"": null,
    ""previous"": null
  },
  ""resources"": [
    {
      ""guid"": ""98028801-441f-41ef-9495-4898262cc237"",
      ""type"": ""bits"",
      ""data"": {
        ""error"": null,
        ""hash"": {
          ""type"": ""sha1"",
          ""value"": null
        }
      },
      ""state"": ""AWAITING_UPLOAD"",
      ""created_at"": ""2016-03-30T10:15:14Z"",
      ""updated_at"": null,
      ""links"": {
        ""self"": {
          ""href"": ""/v3/packages/22de0b8b-171c-49ea-80d8-364fea67d72a""
        },
        ""upload"": {
          ""href"": ""/v3/packages/22de0b8b-171c-49ea-80d8-364fea67d72a/upload"",
          ""method"": ""POST""
        },
        ""download"": {
          ""href"": ""/v3/packages/22de0b8b-171c-49ea-80d8-364fea67d72a/download"",
          ""method"": ""GET""
        },
        ""stage"": {
          ""href"": ""/v3/packages/22de0b8b-171c-49ea-80d8-364fea67d72a/droplets"",
          ""method"": ""POST""
        },
        ""app"": {
          ""href"": ""/v3/apps/79ad15e1-bf92-41fd-b4dc-e52ab03c1628""
        }
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.PackagesExperimental.ListAssociatedPackages(guid).Result;

                Assert.AreEqual("98028801-441f-41ef-9495-4898262cc237", TestUtil.ToTestableString(obj[0].Guid), true);
                Assert.AreEqual("bits", TestUtil.ToTestableString(obj[0].Type), true);
                Assert.AreEqual("AWAITING_UPLOAD", TestUtil.ToTestableString(obj[0].State), true);
                Assert.AreEqual("2016-03-30T10:15:14Z", TestUtil.ToTestableString(obj[0].CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].UpdatedAt), true);

            }
        }

        [TestMethod]
        public void DownloadBitsForPackageTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""guid"": ""d892112a-f835-496d-9073-bdbcb192f6cb"",
  ""type"": ""bits"",
  ""data"": {
    ""error"": null,
    ""hash"": {
      ""type"": ""sha1"",
      ""value"": null
    }
  },
  ""state"": ""PROCESSING_UPLOAD"",
  ""created_at"": ""2016-03-30T10:15:15Z"",
  ""updated_at"": ""2016-03-30T10:15:15Z"",
  ""links"": {
    ""self"": {
      ""href"": ""/v3/packages/9a16c8e4-2711-4195-934a-bbdf30765f53""
    },
    ""upload"": {
      ""href"": ""/v3/packages/9a16c8e4-2711-4195-934a-bbdf30765f53/upload"",
      ""method"": ""POST""
    },
    ""download"": {
      ""href"": ""/v3/packages/9a16c8e4-2711-4195-934a-bbdf30765f53/download"",
      ""method"": ""GET""
    },
    ""stage"": {
      ""href"": ""/v3/packages/9a16c8e4-2711-4195-934a-bbdf30765f53/droplets"",
      ""method"": ""POST""
    },
    ""app"": {
      ""href"": ""/v3/apps/4852bcb2-4b13-4023-83d2-0a74b61f7c0f""
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                dynamic value = null;


                var obj = cfClient.PackagesExperimental.DownloadBitsForPackage(guid, value).Result;


                Assert.AreEqual("d892112a-f835-496d-9073-bdbcb192f6cb", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("bits", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("PROCESSING_UPLOAD", TestUtil.ToTestableString(obj.State), true);
                Assert.AreEqual("2016-03-30T10:15:15Z", TestUtil.ToTestableString(obj.CreatedAt), true);
                Assert.AreEqual("2016-03-30T10:15:15Z", TestUtil.ToTestableString(obj.UpdatedAt), true);

            }
        }

        [TestMethod]
        public void ListAllPackagesTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""pagination"": {
    ""total_results"": 3,
    ""first"": {
      ""href"": ""/v3/packages?page=1=2""
    },
    ""last"": {
      ""href"": ""/v3/packages?page=2=2""
    },
    ""next"": {
      ""href"": ""/v3/packages?page=2=2""
    },
    ""previous"": null
  },
  ""resources"": [
    {
      ""guid"": ""517e37a3-28f9-4610-b9d6-e3d9b68b2b2c"",
      ""type"": ""bits"",
      ""data"": {
        ""error"": null,
        ""hash"": {
          ""type"": ""sha1"",
          ""value"": null
        }
      },
      ""state"": ""AWAITING_UPLOAD"",
      ""created_at"": ""2016-03-30T10:15:14Z"",
      ""updated_at"": null,
      ""links"": {
        ""self"": {
          ""href"": ""/v3/packages/f2e2c0e0-b9f7-46ea-bea1-e202d5e3260b""
        },
        ""upload"": {
          ""href"": ""/v3/packages/f2e2c0e0-b9f7-46ea-bea1-e202d5e3260b/upload"",
          ""method"": ""POST""
        },
        ""download"": {
          ""href"": ""/v3/packages/f2e2c0e0-b9f7-46ea-bea1-e202d5e3260b/download"",
          ""method"": ""GET""
        },
        ""stage"": {
          ""href"": ""/v3/packages/f2e2c0e0-b9f7-46ea-bea1-e202d5e3260b/droplets"",
          ""method"": ""POST""
        },
        ""app"": {
          ""href"": ""/v3/apps/e13827a2-d1d5-4d7b-ba4a-57b587ca8fb4""
        }
      }
    },
    {
      ""guid"": ""517e37a3-28f9-4610-b9d6-e3d9b68b2b2c"",
      ""type"": ""docker"",
      ""data"": {
        ""image"": ""http://location-of-image.com""
      },
      ""state"": ""READY"",
      ""created_at"": ""2016-03-30T10:15:14Z"",
      ""updated_at"": null,
      ""links"": {
        ""self"": {
          ""href"": ""/v3/packages/cbadafb5-2bb8-4923-b0f1-68cafd2f62fb""
        },
        ""stage"": {
          ""href"": ""/v3/packages/cbadafb5-2bb8-4923-b0f1-68cafd2f62fb/droplets"",
          ""method"": ""POST""
        },
        ""app"": {
          ""href"": ""/v3/apps/e13827a2-d1d5-4d7b-ba4a-57b587ca8fb4""
        }
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.PackagesExperimental.ListAllPackages().Result;

                Assert.AreEqual("517e37a3-28f9-4610-b9d6-e3d9b68b2b2c", TestUtil.ToTestableString(obj[0].Guid), true);
                Assert.AreEqual("bits", TestUtil.ToTestableString(obj[0].Type), true);
                Assert.AreEqual("AWAITING_UPLOAD", TestUtil.ToTestableString(obj[0].State), true);
                Assert.AreEqual("2016-03-30T10:15:14Z", TestUtil.ToTestableString(obj[0].CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].UpdatedAt), true);
                Assert.AreEqual("517e37a3-28f9-4610-b9d6-e3d9b68b2b2c", TestUtil.ToTestableString(obj[1].Guid), true);
                Assert.AreEqual("docker", TestUtil.ToTestableString(obj[1].Type), true);
                Assert.AreEqual("READY", TestUtil.ToTestableString(obj[1].State), true);
                Assert.AreEqual("2016-03-30T10:15:14Z", TestUtil.ToTestableString(obj[1].CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].UpdatedAt), true);

            }
        }

        [TestMethod]
        public void DeletePackageTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.PackagesExperimental.DeletePackage(guid).Wait();

            }
        }

    }
}