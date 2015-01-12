using cf_net_sdk.Client.Data;
using cf_net_sdk.Interfaces;
using CloudFoundry.Common;
using CloudFoundry.Common.ServiceLocation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace cf_net_sdk.Client
{
    public class ServicesEndpoint: BaseEndpoint
    {
        public ServicesEndpoint(CloudfoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.auth = client.auth;
        }
    
        /// <summary>
        /// Delete a Particular Service
        /// </summary>
    

    
        public async Task DeleteService(Guid? guid)
    
        {
            string route = string.Format("/v2/services/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
        }
    
        /// <summary>
        /// Updating a Service (deprecated)
        /// </summary>
    

    
        public async Task<UpdateServiceDeprecatedResponse> UpdateServiceDeprecated(UpdateServiceDeprecatedRequest value)
    
        {
            string route = "/v2/services";
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<UpdateServiceDeprecatedResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// List all Service Plans for the Service
        /// </summary>
    
        
        public async Task<PagedResponse<ListAllServicePlansForServiceResponse>> ListAllServicePlansForService(Guid? guid)
        {
            return await ListAllServicePlansForService(guid, new RequestOptions());
        }
        
    

    
        public async Task<PagedResponse<ListAllServicePlansForServiceResponse>> ListAllServicePlansForService(Guid? guid, RequestOptions options)
    
        {
            string route = string.Format("/v2/services/{0}/service_plans", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializePage<ListAllServicePlansForServiceResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Retrieve a Particular Service
        /// </summary>
    
        
    

    
        public async Task<RetrieveServiceResponse> RetrieveService(Guid? guid)
    
        {
            string route = string.Format("/v2/services/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<RetrieveServiceResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// List all Services
        /// </summary>
    
        
        public async Task<PagedResponse<ListAllServicesResponse>> ListAllServices()
        {
            return await ListAllServices(new RequestOptions());
        }
        
    

    
        public async Task<PagedResponse<ListAllServicesResponse>> ListAllServices(RequestOptions options)
    
        {
            string route = "/v2/services";
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializePage<ListAllServicesResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Creating a Service (deprecated)
        /// </summary>
    

    
        public async Task<CreateServiceDeprecatedResponse> CreateServiceDeprecated(CreateServiceDeprecatedRequest value)
    
        {
            string route = "/v2/services";
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Post;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
        
            // TODO: vladi: Implement serialization

            var response = await client.SendAsync();
        
            
            return Util.DeserializeJson<CreateServiceDeprecatedResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
    }
}