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

using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class SecurityGroupRunningDefaultsTest
    {


        [TestMethod]
        public void TestReturnSecurityGroupsUsedForRunningAppsResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""948641b7-61eb-42fe-8a8b-49fc95588d2a"",
        ""url"": ""/v2/config/running_security_groups/9cb2e2a2-9de6-45a8-a56c-be7a58898f80"",
        ""created_at"": ""2016-03-30T10:15:30Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1866"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": true,
        ""staging_default"": false
      }
    }
  ]
}";

            PagedResponseCollection<ReturnSecurityGroupsUsedForRunningAppsResponse> page = Utilities.DeserializePage<ReturnSecurityGroupsUsedForRunningAppsResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("948641b7-61eb-42fe-8a8b-49fc95588d2a", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/running_security_groups/9cb2e2a2-9de6-45a8-a56c-be7a58898f80", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-03-30T10:15:30Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1866", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].StagingDefault), true);
        }

        [TestMethod]
        public void TestSetSecurityGroupAsDefaultForRunningAppsResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""8fca1e6e-eb93-4adb-8408-7a1b41abcdd2"",
    ""url"": ""/v2/config/running_security_groups/8fdd838d-e3a2-4a4b-891e-c6619acad8c0"",
    ""created_at"": ""2016-03-30T10:15:30Z"",
    ""updated_at"": ""2016-03-30T10:15:30Z""
  },
  ""entity"": {
    ""name"": ""name-1867"",
    ""rules"": [
      {
        ""protocol"": ""udp"",
        ""ports"": ""8080"",
        ""destination"": ""198.41.191.47/1""
      }
    ],
    ""running_default"": true,
    ""staging_default"": false
  }
}";

            SetSecurityGroupAsDefaultForRunningAppsResponse obj = Utilities.DeserializeJson<SetSecurityGroupAsDefaultForRunningAppsResponse>(json);

            Assert.AreEqual("8fca1e6e-eb93-4adb-8408-7a1b41abcdd2", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/running_security_groups/8fdd838d-e3a2-4a4b-891e-c6619acad8c0", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-03-30T10:15:30Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-03-30T10:15:30Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1867", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
        }
    }
}
