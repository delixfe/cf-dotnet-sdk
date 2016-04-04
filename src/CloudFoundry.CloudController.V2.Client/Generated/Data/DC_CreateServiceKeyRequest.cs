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

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServiceKeysEndpoint.CreateServiceKey()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/233/service_keys/create_a_service_key.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateServiceKeyRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateServiceKeyRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServiceKeysEndpoint.CreateServiceKey()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/233/service_keys/create_a_service_key.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateServiceKeyRequest
    {

        /// <summary> 
        /// <para>The guid of the service instance for which to create service key</para>
        /// </summary>
        [JsonProperty("service_instance_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServiceInstanceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The name of the service key</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Arbitrary parameters to pass along to the service broker. Must be a JSON object</para>
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Parameters
        {
            get;
            set;
        }
    }
}