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
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class EventsEndpoint : BaseEndpoint
    {
        public EventsEndpoint(CloudFoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.Auth = client.Auth;
        }

        /// <summary>
        /// List Service Delete Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceDeleteEventsExperimentalResponse>> ListServiceDeleteEventsExperimental()
        {
            return await ListServiceDeleteEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServiceDeleteEventsExperimentalResponse>> ListServiceDeleteEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceDeleteEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Plan Visibility Delete Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanVisibilityDeleteEventsExperimentalResponse>> ListServicePlanVisibilityDeleteEventsExperimental()
        {
            return await ListServicePlanVisibilityDeleteEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServicePlanVisibilityDeleteEventsExperimentalResponse>> ListServicePlanVisibilityDeleteEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServicePlanVisibilityDeleteEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Instance Delete Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceInstanceDeleteEventsExperimentalResponse>> ListServiceInstanceDeleteEventsExperimental()
        {
            return await ListServiceInstanceDeleteEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServiceInstanceDeleteEventsExperimentalResponse>> ListServiceInstanceDeleteEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceInstanceDeleteEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Space Delete Events
        /// </summary>
        public async Task<PagedResponseCollection<ListSpaceDeleteEventsResponse>> ListSpaceDeleteEvents()
        {
            return await ListSpaceDeleteEvents(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListSpaceDeleteEventsResponse>> ListSpaceDeleteEvents(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListSpaceDeleteEventsResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Create Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceCreateEventsExperimentalResponse>> ListServiceCreateEventsExperimental()
        {
            return await ListServiceCreateEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServiceCreateEventsExperimentalResponse>> ListServiceCreateEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceCreateEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List App Update Events
        /// </summary>
        public async Task<PagedResponseCollection<ListAppUpdateEventsResponse>> ListAppUpdateEvents()
        {
            return await ListAppUpdateEvents(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAppUpdateEventsResponse>> ListAppUpdateEvents(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAppUpdateEventsResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Events
        /// </summary>
        public async Task<PagedResponseCollection<ListAllEventsResponse>> ListAllEvents()
        {
            return await ListAllEvents(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllEventsResponse>> ListAllEvents(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllEventsResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Space Create Events
        /// </summary>
        public async Task<PagedResponseCollection<ListSpaceCreateEventsResponse>> ListSpaceCreateEvents()
        {
            return await ListSpaceCreateEvents(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListSpaceCreateEventsResponse>> ListSpaceCreateEvents(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListSpaceCreateEventsResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Broker Update Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceBrokerUpdateEventsExperimentalResponse>> ListServiceBrokerUpdateEventsExperimental()
        {
            return await ListServiceBrokerUpdateEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServiceBrokerUpdateEventsExperimentalResponse>> ListServiceBrokerUpdateEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceBrokerUpdateEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Instance Create Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceInstanceCreateEventsExperimentalResponse>> ListServiceInstanceCreateEventsExperimental()
        {
            return await ListServiceInstanceCreateEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServiceInstanceCreateEventsExperimentalResponse>> ListServiceInstanceCreateEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceInstanceCreateEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List events associated with an App since January 1, 2014
        /// </summary>
        public async Task<PagedResponseCollection<ListEventsAssociatedWithAppSinceJanuary12014Response>> ListEventsAssociatedWithAppSinceJanuary12014()
        {
            return await ListEventsAssociatedWithAppSinceJanuary12014(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListEventsAssociatedWithAppSinceJanuary12014Response>> ListEventsAssociatedWithAppSinceJanuary12014(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListEventsAssociatedWithAppSinceJanuary12014Response>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List User Provided Service Instance Create Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListUserProvidedServiceInstanceCreateEventsExperimentalResponse>> ListUserProvidedServiceInstanceCreateEventsExperimental()
        {
            return await ListUserProvidedServiceInstanceCreateEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListUserProvidedServiceInstanceCreateEventsExperimentalResponse>> ListUserProvidedServiceInstanceCreateEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListUserProvidedServiceInstanceCreateEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Dashboard Client Create Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceDashboardClientCreateEventsExperimentalResponse>> ListServiceDashboardClientCreateEventsExperimental()
        {
            return await ListServiceDashboardClientCreateEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServiceDashboardClientCreateEventsExperimentalResponse>> ListServiceDashboardClientCreateEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceDashboardClientCreateEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Plan Visibility Update Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanVisibilityUpdateEventsExperimentalResponse>> ListServicePlanVisibilityUpdateEventsExperimental()
        {
            return await ListServicePlanVisibilityUpdateEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServicePlanVisibilityUpdateEventsExperimentalResponse>> ListServicePlanVisibilityUpdateEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServicePlanVisibilityUpdateEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Update Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceUpdateEventsExperimentalResponse>> ListServiceUpdateEventsExperimental()
        {
            return await ListServiceUpdateEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServiceUpdateEventsExperimentalResponse>> ListServiceUpdateEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceUpdateEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Plan Update Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanUpdateEventsExperimentalResponse>> ListServicePlanUpdateEventsExperimental()
        {
            return await ListServicePlanUpdateEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServicePlanUpdateEventsExperimentalResponse>> ListServicePlanUpdateEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServicePlanUpdateEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List App Create Events
        /// </summary>
        public async Task<PagedResponseCollection<ListAppCreateEventsResponse>> ListAppCreateEvents()
        {
            return await ListAppCreateEvents(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAppCreateEventsResponse>> ListAppCreateEvents(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAppCreateEventsResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Binding Delete Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceBindingDeleteEventsExperimentalResponse>> ListServiceBindingDeleteEventsExperimental()
        {
            return await ListServiceBindingDeleteEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServiceBindingDeleteEventsExperimentalResponse>> ListServiceBindingDeleteEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceBindingDeleteEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular Event
        /// </summary>
        public async Task<RetrieveEventResponse> RetrieveEvent(Guid? guid)
        {
            string route = string.Format("/v2/events/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveEventResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Plan Delete Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanDeleteEventsExperimentalResponse>> ListServicePlanDeleteEventsExperimental()
        {
            return await ListServicePlanDeleteEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServicePlanDeleteEventsExperimentalResponse>> ListServicePlanDeleteEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServicePlanDeleteEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Dashboard Client Delete Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceDashboardClientDeleteEventsExperimentalResponse>> ListServiceDashboardClientDeleteEventsExperimental()
        {
            return await ListServiceDashboardClientDeleteEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServiceDashboardClientDeleteEventsExperimentalResponse>> ListServiceDashboardClientDeleteEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceDashboardClientDeleteEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Instance Update Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceInstanceUpdateEventsExperimentalResponse>> ListServiceInstanceUpdateEventsExperimental()
        {
            return await ListServiceInstanceUpdateEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServiceInstanceUpdateEventsExperimentalResponse>> ListServiceInstanceUpdateEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceInstanceUpdateEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List User Provided Service Instance Delete Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListUserProvidedServiceInstanceDeleteEventsExperimentalResponse>> ListUserProvidedServiceInstanceDeleteEventsExperimental()
        {
            return await ListUserProvidedServiceInstanceDeleteEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListUserProvidedServiceInstanceDeleteEventsExperimentalResponse>> ListUserProvidedServiceInstanceDeleteEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListUserProvidedServiceInstanceDeleteEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Space Update Events
        /// </summary>
        public async Task<PagedResponseCollection<ListSpaceUpdateEventsResponse>> ListSpaceUpdateEvents()
        {
            return await ListSpaceUpdateEvents(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListSpaceUpdateEventsResponse>> ListSpaceUpdateEvents(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListSpaceUpdateEventsResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Plan Visibility Create Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanVisibilityCreateEventsExperimentalResponse>> ListServicePlanVisibilityCreateEventsExperimental()
        {
            return await ListServicePlanVisibilityCreateEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServicePlanVisibilityCreateEventsExperimentalResponse>> ListServicePlanVisibilityCreateEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServicePlanVisibilityCreateEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Broker Create Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceBrokerCreateEventsExperimentalResponse>> ListServiceBrokerCreateEventsExperimental()
        {
            return await ListServiceBrokerCreateEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServiceBrokerCreateEventsExperimentalResponse>> ListServiceBrokerCreateEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceBrokerCreateEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List App Delete Events
        /// </summary>
        public async Task<PagedResponseCollection<ListAppDeleteEventsResponse>> ListAppDeleteEvents()
        {
            return await ListAppDeleteEvents(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAppDeleteEventsResponse>> ListAppDeleteEvents(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAppDeleteEventsResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List User Provided Service Instance Update Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListUserProvidedServiceInstanceUpdateEventsExperimentalResponse>> ListUserProvidedServiceInstanceUpdateEventsExperimental()
        {
            return await ListUserProvidedServiceInstanceUpdateEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListUserProvidedServiceInstanceUpdateEventsExperimentalResponse>> ListUserProvidedServiceInstanceUpdateEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListUserProvidedServiceInstanceUpdateEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Broker Delete Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceBrokerDeleteEventsExperimentalResponse>> ListServiceBrokerDeleteEventsExperimental()
        {
            return await ListServiceBrokerDeleteEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServiceBrokerDeleteEventsExperimentalResponse>> ListServiceBrokerDeleteEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceBrokerDeleteEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Plan Create Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServicePlanCreateEventsExperimentalResponse>> ListServicePlanCreateEventsExperimental()
        {
            return await ListServicePlanCreateEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServicePlanCreateEventsExperimentalResponse>> ListServicePlanCreateEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServicePlanCreateEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List App Exited Events
        /// </summary>
        public async Task<PagedResponseCollection<ListAppExitedEventsResponse>> ListAppExitedEvents()
        {
            return await ListAppExitedEvents(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAppExitedEventsResponse>> ListAppExitedEvents(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAppExitedEventsResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List Service Binding Create Events (experimental)
        /// </summary>
        public async Task<PagedResponseCollection<ListServiceBindingCreateEventsExperimentalResponse>> ListServiceBindingCreateEventsExperimental()
        {
            return await ListServiceBindingCreateEventsExperimental(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListServiceBindingCreateEventsExperimentalResponse>> ListServiceBindingCreateEventsExperimental(RequestOptions options)
        {
            string route = "/v2/events";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListServiceBindingCreateEventsExperimentalResponse>(await response.ReadContentAsStringAsync());
        }
    }
}