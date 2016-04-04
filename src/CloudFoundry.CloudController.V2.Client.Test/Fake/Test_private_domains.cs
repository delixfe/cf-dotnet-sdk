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
    public class PrivateDomainsEndpoint
{
        [TestMethod]
        public void RetrievePrivateDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""6aa7a94f-4b48-4851-a124-26affd8b14b5"",
    ""url"": ""/v2/private_domains/aa6c6120-2136-456f-8175-b0ac3f3073e3"",
    ""created_at"": ""2016-03-30T10:15:02Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""vcap.me"",
    ""owning_organization_guid"": ""6aa7a94f-4b48-4851-a124-26affd8b14b5"",
    ""owning_organization_url"": ""/v2/organizations/ee67d2b2-6520-41ac-bd96-d7a4fcd59642"",
    ""shared_organizations_url"": ""/v2/private_domains/aa6c6120-2136-456f-8175-b0ac3f3073e3/shared_organizations""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.PrivateDomains.RetrievePrivateDomain(guid).Result;


                Assert.AreEqual("6aa7a94f-4b48-4851-a124-26affd8b14b5", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/aa6c6120-2136-456f-8175-b0ac3f3073e3", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-30T10:15:02Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("vcap.me", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("6aa7a94f-4b48-4851-a124-26affd8b14b5", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/ee67d2b2-6520-41ac-bd96-d7a4fcd59642", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/private_domains/aa6c6120-2136-456f-8175-b0ac3f3073e3/shared_organizations", TestUtil.ToTestableString(obj.SharedOrganizationsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllPrivateDomainsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 4,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""5114342b-48eb-4d94-92ba-31f346de0a6f"",
        ""url"": ""/v2/private_domains/aa6c6120-2136-456f-8175-b0ac3f3073e3"",
        ""created_at"": ""2016-03-30T10:15:02Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""vcap.me"",
        ""owning_organization_guid"": ""5114342b-48eb-4d94-92ba-31f346de0a6f"",
        ""owning_organization_url"": ""/v2/organizations/ee67d2b2-6520-41ac-bd96-d7a4fcd59642"",
        ""shared_organizations_url"": ""/v2/private_domains/aa6c6120-2136-456f-8175-b0ac3f3073e3/shared_organizations""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""5114342b-48eb-4d94-92ba-31f346de0a6f"",
        ""url"": ""/v2/private_domains/08faa8d3-a62b-4388-8a41-e1dd1d7f1a5e"",
        ""created_at"": ""2016-03-30T10:15:06Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-11.example.com"",
        ""owning_organization_guid"": ""5114342b-48eb-4d94-92ba-31f346de0a6f"",
        ""owning_organization_url"": ""/v2/organizations/6c9ecab3-60b3-4618-866b-275c0a3d65dc"",
        ""shared_organizations_url"": ""/v2/private_domains/08faa8d3-a62b-4388-8a41-e1dd1d7f1a5e/shared_organizations""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""5114342b-48eb-4d94-92ba-31f346de0a6f"",
        ""url"": ""/v2/private_domains/be985e8a-f78c-49be-a609-9c3e315778a3"",
        ""created_at"": ""2016-03-30T10:15:06Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-12.example.com"",
        ""owning_organization_guid"": ""5114342b-48eb-4d94-92ba-31f346de0a6f"",
        ""owning_organization_url"": ""/v2/organizations/e596235f-12bf-4750-8ef4-f24bf7b8de28"",
        ""shared_organizations_url"": ""/v2/private_domains/be985e8a-f78c-49be-a609-9c3e315778a3/shared_organizations""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""5114342b-48eb-4d94-92ba-31f346de0a6f"",
        ""url"": ""/v2/private_domains/87bdcb8d-ee6b-4e8e-8cb8-3a29ba48afcb"",
        ""created_at"": ""2016-03-30T10:15:06Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-13.example.com"",
        ""owning_organization_guid"": ""5114342b-48eb-4d94-92ba-31f346de0a6f"",
        ""owning_organization_url"": ""/v2/organizations/edb527b8-9cba-42f3-b649-99458f13040c"",
        ""shared_organizations_url"": ""/v2/private_domains/87bdcb8d-ee6b-4e8e-8cb8-3a29ba48afcb/shared_organizations""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.PrivateDomains.ListAllPrivateDomains().Result;

                Assert.AreEqual("4", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("5114342b-48eb-4d94-92ba-31f346de0a6f", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/aa6c6120-2136-456f-8175-b0ac3f3073e3", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-30T10:15:02Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("vcap.me", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("5114342b-48eb-4d94-92ba-31f346de0a6f", TestUtil.ToTestableString(obj[0].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/ee67d2b2-6520-41ac-bd96-d7a4fcd59642", TestUtil.ToTestableString(obj[0].OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/private_domains/aa6c6120-2136-456f-8175-b0ac3f3073e3/shared_organizations", TestUtil.ToTestableString(obj[0].SharedOrganizationsUrl), true);
                Assert.AreEqual("5114342b-48eb-4d94-92ba-31f346de0a6f", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/08faa8d3-a62b-4388-8a41-e1dd1d7f1a5e", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-30T10:15:06Z", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-11.example.com", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("5114342b-48eb-4d94-92ba-31f346de0a6f", TestUtil.ToTestableString(obj[1].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/6c9ecab3-60b3-4618-866b-275c0a3d65dc", TestUtil.ToTestableString(obj[1].OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/private_domains/08faa8d3-a62b-4388-8a41-e1dd1d7f1a5e/shared_organizations", TestUtil.ToTestableString(obj[1].SharedOrganizationsUrl), true);
                Assert.AreEqual("5114342b-48eb-4d94-92ba-31f346de0a6f", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/be985e8a-f78c-49be-a609-9c3e315778a3", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-30T10:15:06Z", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-12.example.com", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("5114342b-48eb-4d94-92ba-31f346de0a6f", TestUtil.ToTestableString(obj[2].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/e596235f-12bf-4750-8ef4-f24bf7b8de28", TestUtil.ToTestableString(obj[2].OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/private_domains/be985e8a-f78c-49be-a609-9c3e315778a3/shared_organizations", TestUtil.ToTestableString(obj[2].SharedOrganizationsUrl), true);
                Assert.AreEqual("5114342b-48eb-4d94-92ba-31f346de0a6f", TestUtil.ToTestableString(obj[3].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/87bdcb8d-ee6b-4e8e-8cb8-3a29ba48afcb", TestUtil.ToTestableString(obj[3].EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-30T10:15:06Z", TestUtil.ToTestableString(obj[3].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-13.example.com", TestUtil.ToTestableString(obj[3].Name), true);
                Assert.AreEqual("5114342b-48eb-4d94-92ba-31f346de0a6f", TestUtil.ToTestableString(obj[3].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/edb527b8-9cba-42f3-b649-99458f13040c", TestUtil.ToTestableString(obj[3].OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/private_domains/87bdcb8d-ee6b-4e8e-8cb8-3a29ba48afcb/shared_organizations", TestUtil.ToTestableString(obj[3].SharedOrganizationsUrl), true);

            }
        }

        [TestMethod]
        public void DeletePrivateDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.PrivateDomains.DeletePrivateDomain(guid).Wait();

            }
        }

        [TestMethod]
        public void CreatePrivateDomainOwnedByGivenOrganizationTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""866d29aa-83fe-41fd-973a-37d01dafc9b7"",
    ""url"": ""/v2/private_domains/29a7f59a-b66d-4fe0-bbbf-8133dc72433a"",
    ""created_at"": ""2016-03-30T10:15:07Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""exmaple.com"",
    ""owning_organization_guid"": ""866d29aa-83fe-41fd-973a-37d01dafc9b7"",
    ""owning_organization_url"": ""/v2/organizations/b9628c24-fdd7-4e1c-86d5-f1119adee45b"",
    ""shared_organizations_url"": ""/v2/private_domains/29a7f59a-b66d-4fe0-bbbf-8133dc72433a/shared_organizations""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreatePrivateDomainOwnedByGivenOrganizationRequest value = new CreatePrivateDomainOwnedByGivenOrganizationRequest();


                var obj = cfClient.PrivateDomains.CreatePrivateDomainOwnedByGivenOrganization(value).Result;


                Assert.AreEqual("866d29aa-83fe-41fd-973a-37d01dafc9b7", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/29a7f59a-b66d-4fe0-bbbf-8133dc72433a", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-30T10:15:07Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("exmaple.com", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("866d29aa-83fe-41fd-973a-37d01dafc9b7", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/b9628c24-fdd7-4e1c-86d5-f1119adee45b", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/private_domains/29a7f59a-b66d-4fe0-bbbf-8133dc72433a/shared_organizations", TestUtil.ToTestableString(obj.SharedOrganizationsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllSharedOrganizationsForPrivateDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""1d931faf-9447-4308-9ca6-5cbf52effa88"",
        ""url"": ""/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44"",
        ""created_at"": ""2016-03-30T10:15:06Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-92"",
        ""billing_enabled"": false,
        ""quota_definition_guid"": ""1d931faf-9447-4308-9ca6-5cbf52effa88"",
        ""status"": ""active"",
        ""quota_definition_url"": ""/v2/quota_definitions/3e681916-df1b-41dd-aca1-5ce83214b705"",
        ""spaces_url"": ""/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/spaces"",
        ""domains_url"": ""/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/domains"",
        ""private_domains_url"": ""/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/private_domains"",
        ""users_url"": ""/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/users"",
        ""managers_url"": ""/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/managers"",
        ""billing_managers_url"": ""/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/billing_managers"",
        ""auditors_url"": ""/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/auditors"",
        ""app_events_url"": ""/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/app_events"",
        ""space_quota_definitions_url"": ""/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/space_quota_definitions""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.PrivateDomains.ListAllSharedOrganizationsForPrivateDomain(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("1d931faf-9447-4308-9ca6-5cbf52effa88", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-30T10:15:06Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-92", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].BillingEnabled), true);
                Assert.AreEqual("1d931faf-9447-4308-9ca6-5cbf52effa88", TestUtil.ToTestableString(obj[0].QuotaDefinitionGuid), true);
                Assert.AreEqual("active", TestUtil.ToTestableString(obj[0].Status), true);
                Assert.AreEqual("/v2/quota_definitions/3e681916-df1b-41dd-aca1-5ce83214b705", TestUtil.ToTestableString(obj[0].QuotaDefinitionUrl), true);
                Assert.AreEqual("/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/spaces", TestUtil.ToTestableString(obj[0].SpacesUrl), true);
                Assert.AreEqual("/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/domains", TestUtil.ToTestableString(obj[0].DomainsUrl), true);
                Assert.AreEqual("/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/private_domains", TestUtil.ToTestableString(obj[0].PrivateDomainsUrl), true);
                Assert.AreEqual("/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/users", TestUtil.ToTestableString(obj[0].UsersUrl), true);
                Assert.AreEqual("/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/managers", TestUtil.ToTestableString(obj[0].ManagersUrl), true);
                Assert.AreEqual("/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/billing_managers", TestUtil.ToTestableString(obj[0].BillingManagersUrl), true);
                Assert.AreEqual("/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/auditors", TestUtil.ToTestableString(obj[0].AuditorsUrl), true);
                Assert.AreEqual("/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/app_events", TestUtil.ToTestableString(obj[0].AppEventsUrl), true);
                Assert.AreEqual("/v2/organizations/5e6cd3e8-6937-4a8c-b465-ded471900c44/space_quota_definitions", TestUtil.ToTestableString(obj[0].SpaceQuotaDefinitionsUrl), true);

            }
        }

        [TestMethod]
        public void FilterPrivateDomainsByNameTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""90be86c3-6094-4711-b769-89dc225c9d02"",
        ""url"": ""/v2/private_domains/4beccb65-2f59-4285-a2ea-8474e68d72fe"",
        ""created_at"": ""2016-03-30T10:15:06Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""my-domain.com"",
        ""owning_organization_guid"": ""90be86c3-6094-4711-b769-89dc225c9d02"",
        ""owning_organization_url"": ""/v2/organizations/3b6ba42d-f1e7-43b1-8471-abb7c34e7b23"",
        ""shared_organizations_url"": ""/v2/private_domains/4beccb65-2f59-4285-a2ea-8474e68d72fe/shared_organizations""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.PrivateDomains.FilterPrivateDomainsByName().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("90be86c3-6094-4711-b769-89dc225c9d02", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/4beccb65-2f59-4285-a2ea-8474e68d72fe", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-30T10:15:06Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("my-domain.com", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("90be86c3-6094-4711-b769-89dc225c9d02", TestUtil.ToTestableString(obj[0].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/3b6ba42d-f1e7-43b1-8471-abb7c34e7b23", TestUtil.ToTestableString(obj[0].OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/private_domains/4beccb65-2f59-4285-a2ea-8474e68d72fe/shared_organizations", TestUtil.ToTestableString(obj[0].SharedOrganizationsUrl), true);

            }
        }

    }
}