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

using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.V2.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client
{
    /// <summary>
    /// Spaces Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class SpacesEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractSpacesEndpoint
    {
        internal SpacesEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for Spaces Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractSpacesEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractSpacesEndpoint()
        {
        }

        /// <summary>
        /// Get Space summary
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/get_space_summary.html"</para>
        /// </summary>
        public async Task<GetSpaceSummaryResponse> GetSpaceSummary(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/summary", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<GetSpaceSummaryResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Auditor with the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/associate_auditor_with_the_space.html"</para>
        /// </summary>
        public async Task<AssociateAuditorWithSpaceResponse> AssociateAuditorWithSpace(Guid? guid, Guid? auditor_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/auditors/{1}", guid, auditor_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateAuditorWithSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Developers for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_developers_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDevelopersForSpaceResponse>> ListAllDevelopersForSpace(Guid? guid)
        {
            return await ListAllDevelopersForSpace(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Developers for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_developers_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDevelopersForSpaceResponse>> ListAllDevelopersForSpace(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/developers", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllDevelopersForSpaceResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Remove Security Group from the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/remove_security_group_from_the_space.html"</para>
        /// </summary>
        public async Task<RemoveSecurityGroupFromSpaceResponse> RemoveSecurityGroupFromSpace(Guid? guid, Guid? security_group_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/security_groups/{1}", guid, security_group_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveSecurityGroupFromSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Creating a Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/creating_a_space.html"</para>
        /// </summary>
        public async Task<CreateSpaceResponse> CreateSpace(CreateSpaceRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/spaces";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Developer from the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/remove_developer_from_the_space.html"</para>
        /// </summary>
        public async Task<RemoveDeveloperFromSpaceResponse> RemoveDeveloperFromSpace(Guid? guid, Guid? developer_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/developers/{1}", guid, developer_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveDeveloperFromSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Managers for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_managers_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllManagersForSpaceResponse>> ListAllManagersForSpace(Guid? guid)
        {
            return await ListAllManagersForSpace(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Managers for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_managers_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllManagersForSpaceResponse>> ListAllManagersForSpace(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/managers", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllManagersForSpaceResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List all Service Instances for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_service_instances_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceInstancesForSpaceResponse>> ListAllServiceInstancesForSpace(Guid? guid)
        {
            return await ListAllServiceInstancesForSpace(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Service Instances for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_service_instances_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceInstancesForSpaceResponse>> ListAllServiceInstancesForSpace(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/service_instances", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServiceInstancesForSpaceResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Remove Auditor from the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/remove_auditor_from_the_space.html"</para>
        /// </summary>
        public async Task<RemoveAuditorFromSpaceResponse> RemoveAuditorFromSpace(Guid? guid, Guid? auditor_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/auditors/{1}", guid, auditor_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveAuditorFromSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Apps for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_apps_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAppsForSpaceResponse>> ListAllAppsForSpace(Guid? guid)
        {
            return await ListAllAppsForSpace(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Apps for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_apps_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAppsForSpaceResponse>> ListAllAppsForSpace(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/apps", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllAppsForSpaceResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Retrieve a Particular Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/retrieve_a_particular_space.html"</para>
        /// </summary>
        public async Task<RetrieveSpaceResponse> RetrieveSpace(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Events for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_events_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllEventsForSpaceResponse>> ListAllEventsForSpace(Guid? guid)
        {
            return await ListAllEventsForSpace(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Events for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_events_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllEventsForSpaceResponse>> ListAllEventsForSpace(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/events", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllEventsForSpaceResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Associate Security Group with the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/associate_security_group_with_the_space.html"</para>
        /// </summary>
        public async Task<AssociateSecurityGroupWithSpaceResponse> AssociateSecurityGroupWithSpace(Guid? guid, Guid? security_group_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/security_groups/{1}", guid, security_group_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateSecurityGroupWithSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Manager from the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/remove_manager_from_the_space.html"</para>
        /// </summary>
        public async Task<RemoveManagerFromSpaceResponse> RemoveManagerFromSpace(Guid? guid, Guid? manager_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/managers/{1}", guid, manager_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveManagerFromSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Services for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_services_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicesForSpaceResponse>> ListAllServicesForSpace(Guid? guid)
        {
            return await ListAllServicesForSpace(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Services for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_services_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicesForSpaceResponse>> ListAllServicesForSpace(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/services", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServicesForSpaceResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Associate Developer with the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/associate_developer_with_the_space.html"</para>
        /// </summary>
        public async Task<AssociateDeveloperWithSpaceResponse> AssociateDeveloperWithSpace(Guid? guid, Guid? developer_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/developers/{1}", guid, developer_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateDeveloperWithSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Security Groups for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_security_groups_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSecurityGroupsForSpaceResponse>> ListAllSecurityGroupsForSpace(Guid? guid)
        {
            return await ListAllSecurityGroupsForSpace(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Security Groups for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_security_groups_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSecurityGroupsForSpaceResponse>> ListAllSecurityGroupsForSpace(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/security_groups", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSecurityGroupsForSpaceResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List all Domains for the Space (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_domains_for_the_space_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDomainsForSpaceDeprecatedResponse>> ListAllDomainsForSpaceDeprecated(Guid? guid)
        {
            return await ListAllDomainsForSpaceDeprecated(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Domains for the Space (deprecated)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_domains_for_the_space_(deprecated).html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDomainsForSpaceDeprecatedResponse>> ListAllDomainsForSpaceDeprecated(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/domains", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllDomainsForSpaceDeprecatedResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Delete a Particular Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/delete_a_particular_space.html"</para>
        /// </summary>
        public async Task DeleteSpace(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// List all Routes for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_routes_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllRoutesForSpaceResponse>> ListAllRoutesForSpace(Guid? guid)
        {
            return await ListAllRoutesForSpace(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Routes for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_routes_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllRoutesForSpaceResponse>> ListAllRoutesForSpace(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/routes", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllRoutesForSpaceResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// List all Spaces
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_spaces.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesResponse>> ListAllSpaces()
        {
            return await ListAllSpaces(new RequestOptions());
        }

        /// <summary>
        /// List all Spaces
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_spaces.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesResponse>> ListAllSpaces(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/spaces";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSpacesResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Associate Manager with the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/associate_manager_with_the_space.html"</para>
        /// </summary>
        public async Task<AssociateManagerWithSpaceResponse> AssociateManagerWithSpace(Guid? guid, Guid? manager_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/managers/{1}", guid, manager_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateManagerWithSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Update a Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/update_a_space.html"</para>
        /// </summary>
        public async Task<UpdateSpaceResponse> UpdateSpace(Guid? guid, UpdateSpaceRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Auditors for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_auditors_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAuditorsForSpaceResponse>> ListAllAuditorsForSpace(Guid? guid)
        {
            return await ListAllAuditorsForSpace(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Auditors for the Space
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/202/spaces/list_all_auditors_for_the_space.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAuditorsForSpaceResponse>> ListAllAuditorsForSpace(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/spaces/{0}/auditors", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllAuditorsForSpaceResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }
    }
}
