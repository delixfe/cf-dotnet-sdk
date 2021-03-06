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
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Test.Serialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class UsersTest
    {

        [TestMethod]
        public void TestUpdateUserRequest()
        {
            string json = @"{
  ""default_space_guid"": ""314ce970-8f14-4049-b769-0b41a6a86487""
}";

            UpdateUserRequest request = new UpdateUserRequest();

            request.DefaultSpaceGuid = new Guid("314ce970-8f14-4049-b769-0b41a6a86487");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateUserRequest()
        {
            string json = @"{
  ""guid"": ""75f66c91-c6bc-4049-ae08-35e1adef4cfc""
}";

            CreateUserRequest request = new CreateUserRequest();

            request.Guid = new Guid("75f66c91-c6bc-4049-ae08-35e1adef4cfc");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
