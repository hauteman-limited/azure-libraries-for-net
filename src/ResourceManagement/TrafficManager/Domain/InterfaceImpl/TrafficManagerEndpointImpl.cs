// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.TrafficManager.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Update;
    using Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition;
    using Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update;
    using Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateAzureEndpoint;
    using Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition;
    using Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateExternalEndpoint;
    using Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateNestedProfileEndpoint;
    using Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition;
    using Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update;
    using Microsoft.Azure.Management.TrafficManager.Fluent.Models;
    using System.Collections.Generic;

    internal partial class TrafficManagerEndpointImpl
    {
        /// <summary>
        /// Specifies the geographic location for the endpoint that will be used when the parent profile is configured
        /// with Geographic based routing method  TrafficRoutingMethod.GEOGRAPHIC.
        /// </summary>
        /// <param name="geographicLocation">The geographic location.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithAttach<TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithGeographicLocation<TrafficManagerProfile.Definition.IWithCreate>.WithGeographicLocation(IGeographicLocation geographicLocation)
        {
            return this.WithGeographicLocation(geographicLocation);
        }

        /// <summary>
        /// Specifies the geographic location for the endpoint that will be used when the parent profile is configured
        /// with Geographic based routing method  TrafficRoutingMethod.GEOGRAPHIC.
        /// </summary>
        /// <param name="geographicLocationCode">The geographic location code.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithAttach<TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithGeographicLocation<TrafficManagerProfile.Definition.IWithCreate>.WithGeographicLocation(string geographicLocationCode)
        {
            return this.WithGeographicLocation(geographicLocationCode);
        }

        /// <summary>
        /// Specifies the list of geographic location for the endpoint that will be used when the parent profile is
        /// configured with Geographic based routing method  TrafficRoutingMethod.GEOGRAPHIC.
        /// </summary>
        /// <param name="geographicLocations">The geographic locations.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithAttach<TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithGeographicLocation<TrafficManagerProfile.Definition.IWithCreate>.WithGeographicLocations(IList<Microsoft.Azure.Management.TrafficManager.Fluent.IGeographicLocation> geographicLocations)
        {
            return this.WithGeographicLocations(geographicLocations);
        }

        /// <summary>
        /// Specifies the list of geographic location for the endpoint that will be used when the parent profile is
        /// configured with Geographic based routing method  TrafficRoutingMethod.GEOGRAPHIC.
        /// </summary>
        /// <param name="geographicLocationCodes">The geographic location codes.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithAttach<TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithGeographicLocation<TrafficManagerProfile.Definition.IWithCreate>.WithGeographicLocations(IList<string> geographicLocationCodes)
        {
            return this.WithGeographicLocations(geographicLocationCodes);
        }

        /// <summary>
        /// Specifies the geographic location for the endpoint that will be used when the parent profile is configured
        /// with Geographic based routing method  TrafficRoutingMethod.GEOGRAPHIC.
        /// </summary>
        /// <param name="geographicLocation">The geographic location.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithAttach<TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithGeographicLocation<TrafficManagerProfile.Update.IUpdate>.WithGeographicLocation(IGeographicLocation geographicLocation)
        {
            return this.WithGeographicLocation(geographicLocation);
        }

        /// <summary>
        /// Specifies the geographic location for the endpoint that will be used when the parent profile is configured
        /// with Geographic based routing method  TrafficRoutingMethod.GEOGRAPHIC.
        /// </summary>
        /// <param name="geographicLocationCode">The geographic location code.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithAttach<TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithGeographicLocation<TrafficManagerProfile.Update.IUpdate>.WithGeographicLocation(string geographicLocationCode)
        {
            return this.WithGeographicLocation(geographicLocationCode);
        }

        /// <summary>
        /// Specifies the list of geographic location for the endpoint that will be used when the parent profile is
        /// configured with Geographic based routing method  TrafficRoutingMethod.GEOGRAPHIC.
        /// </summary>
        /// <param name="geographicLocations">The geographic locations.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithAttach<TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithGeographicLocation<TrafficManagerProfile.Update.IUpdate>.WithGeographicLocations(IList<Microsoft.Azure.Management.TrafficManager.Fluent.IGeographicLocation> geographicLocations)
        {
            return this.WithGeographicLocations(geographicLocations);
        }

        /// <summary>
        /// Specifies the list of geographic location for the endpoint that will be used when the parent profile is
        /// configured with Geographic based routing method  TrafficRoutingMethod.GEOGRAPHIC.
        /// </summary>
        /// <param name="geographicLocationCodes">The geographic location codes.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithAttach<TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithGeographicLocation<TrafficManagerProfile.Update.IUpdate>.WithGeographicLocations(IList<string> geographicLocationCodes)
        {
            return this.WithGeographicLocations(geographicLocationCodes);
        }

        /// <summary>
        /// Specifies the geographic location for the endpoint that will be used when the parent profile is configured
        /// with Geographic based routing method  TrafficRoutingMethod.GEOGRAPHIC.
        /// </summary>
        /// <param name="geographicLocation">The geographic location.</param>
        /// <return>The next stage of the update.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithGeographicLocation.WithGeographicLocation(IGeographicLocation geographicLocation)
        {
            return this.WithGeographicLocation(geographicLocation);
        }

        /// <summary>
        /// Specifies the geographic location for the endpoint that will be used when the parent profile is configured
        /// with Geographic based routing method  TrafficRoutingMethod.GEOGRAPHIC.
        /// </summary>
        /// <param name="geographicLocationCode">The geographic location code.</param>
        /// <return>The next stage of the update.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithGeographicLocation.WithGeographicLocation(string geographicLocationCode)
        {
            return this.WithGeographicLocation(geographicLocationCode);
        }

        /// <summary>
        /// Specifies the list of geographic location for the endpoint that will be used when the parent profile is
        /// configured with Geographic based routing method  TrafficRoutingMethod.GEOGRAPHIC.
        /// </summary>
        /// <param name="geographicLocations">The geographic locations.</param>
        /// <return>The next stage of the update.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithGeographicLocation.WithGeographicLocations(IList<Microsoft.Azure.Management.TrafficManager.Fluent.IGeographicLocation> geographicLocations)
        {
            return this.WithGeographicLocations(geographicLocations);
        }

        /// <summary>
        /// Specifies the list of geographic location for the endpoint that will be used when the parent profile is
        /// configured with Geographic based routing method  TrafficRoutingMethod.GEOGRAPHIC.
        /// </summary>
        /// <param name="geographicLocationCodes">The geographic location codes.</param>
        /// <return>The next stage of the update.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithGeographicLocation.WithGeographicLocations(IList<string> geographicLocationCodes)
        {
            return this.WithGeographicLocations(geographicLocationCodes);
        }

        /// <summary>
        /// Specifies the geographic location to be removed from the endpoint's geographic location entries.
        /// </summary>
        /// <param name="geographicLocation">The geographic location.</param>
        /// <return>The next stage of the update.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithGeographicLocation.WithoutGeographicLocation(IGeographicLocation geographicLocation)
        {
            return this.WithoutGeographicLocation(geographicLocation);
        }

        /// <summary>
        /// Specifies the geographic location to be removed from the endpoint's geographic location entries.
        /// </summary>
        /// <param name="geographicLocationCode">The geographic location code.</param>
        /// <return>The next stage of the update.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithGeographicLocation.WithoutGeographicLocation(string geographicLocationCode)
        {
            return this.WithoutGeographicLocation(geographicLocationCode);
        }

        /// <summary>
        /// Specifies that this endpoint should be excluded from receiving traffic.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithTrafficDisabled<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate>.WithTrafficDisabled()
        {
            return this.WithTrafficDisabled();
        }

        /// <summary>
        /// Specifies that this endpoint should be excluded from receiving traffic.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithTrafficDisabled<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate>.WithTrafficDisabled()
        {
            return this.WithTrafficDisabled();
        }

        /// <summary>
        /// Specifies the location of the endpoint that will be used when the parent profile is configured with
        /// Performance routing method  TrafficRoutingMethod.PERFORMANCE.
        /// </summary>
        /// <param name="region">The location.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithEndpointThreshold<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithSourceTrafficRegionThenThreshold<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate>.FromRegion(Microsoft.Azure.Management.ResourceManager.Fluent.Core.Region region)
        {
            return this.FromRegion(region);
        }

        /// <summary>
        /// Specifies the location of the endpoint that will be used when the parent profile is configured with
        /// Performance routing method  TrafficRoutingMethod.PERFORMANCE.
        /// </summary>
        /// <param name="region">The location.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithEndpointThreshold<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithSourceTrafficRegionThenThreshold<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate>.FromRegion(Microsoft.Azure.Management.ResourceManager.Fluent.Core.Region region)
        {
            return this.FromRegion(region);
        }

        /// <summary>
        /// Specifies the priority for the endpoint that will be used when the parent profile is configured with
        /// Priority routing method  TrafficRoutingMethod.PRIORITY.
        /// </summary>
        /// <param name="priority">The endpoint priority.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithRoutingPriority<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate>.WithRoutingPriority(int priority)
        {
            return this.WithRoutingPriority(priority);
        }

        /// <summary>
        /// Specifies the weight for the endpoint that will be used when priority-based routing method
        /// is  TrafficRoutingMethod.PRIORITY enabled on the profile.
        /// </summary>
        /// <param name="priority">
        /// Priority of this endpoint. Possible values are from 1 to 1000, lower
        /// values represent higher priority.
        /// </param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithRoutingPriority<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate>.WithRoutingPriority(int priority)
        {
            return this.WithRoutingPriority(priority);
        }

        /// <summary>
        /// Specifies the priority for the endpoint that will be used when the parent profile is configured with
        /// Subnet routing method  TrafficRoutingMethod.SUBNET.
        /// </summary>
        /// <param name="first">first address of the range.</param>
        /// <param name="last">last address of the range.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithSubnetRouting<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate>.WithSubnetRouting(string first, string last)
        {
            return this.WithSubnetRouting(first, last);       
        }

        /// <summary>
        /// Specifies the priority for the endpoint that will be used when the parent profile is configured with
        /// Subnet routing method  TrafficRoutingMethod.SUBNET.
        /// </summary>
        /// <param name="first">first address of the range.</param>
        /// <param name="last">last address of the range.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithSubnetRouting<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate>.WithSubnetRouting(string first, string last)
        {
            return this.WithSubnetRouting(first, last);            
        }

        /// <summary>
        /// Specifies the priority for the endpoint that will be used when the parent profile is configured with
        /// Subnet routing method  TrafficRoutingMethod.SUBNET.
        /// </summary>
        /// <param name="ipAddress">first address of the range.</param>
        /// <param name="mask">last address of the range.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithSubnetRouting<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate>.WithSubnetRouting(string ipAddress, int mask)
        {            
            return this.WithSubnetRouting(ipAddress, mask);
        }

        /// <summary>
        /// Specifies the priority for the endpoint that will be used when the parent profile is configured with
        /// Subnet routing method  TrafficRoutingMethod.SUBNET.
        /// </summary>
        /// <param name="ipAddress">first address of the range.</param>
        /// <param name="mask">last address of the range.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithSubnetRouting<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate>.WithSubnetRouting(string ipAddress, int mask)
        {            
            return this.WithSubnetRouting(ipAddress, mask);
        }

        /// <summary>
        /// Specifies the custom header for the endpoint that will be used with health checks        
        /// </summary>
        /// <param name="headers">list of custom headers.</param>        
        /// <return>The next stage of the definition.</return>

        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithCustomHeaders<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate>.WithCustomHeaders(IDictionary<string, string> headers)
        {
            return this.WithCustomHeaders(headers);
        }

        /// <summary>
        /// Specifies the custom header for the endpoint that will be used with health checks        
        /// </summary>
        /// <param name="headers">list of custom headers.</param>        
        /// <return>The next stage of the definition.</return>

        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithCustomHeaders<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate>.WithCustomHeaders(IDictionary<string, string> headers)
        {
            return this.WithCustomHeaders(headers);
        }

        /// <summary>
        /// Specifies the custom header for the endpoint that will be used with health checks
        /// </summary>
        /// <param name="name">custome header name.</param>
        /// <param name="value">custom header value.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithCustomHeaders<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate>.WithCustomHeader(string name, string value)
        {
            return this.WithCustomHeader(name, value);
        }

        /// <summary>
        /// Specifies the custom header for the endpoint that will be used with health checks
        /// </summary>
        /// <param name="name">custome header name.</param>
        /// <param name="value">custom header value.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithCustomHeaders<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate>.WithCustomHeader(string name, string value)
        {
            return this.WithCustomHeader(name, value);
        }

        /// <summary>
        /// Specifies that the endpoint should receive the traffic.
        /// </summary>
        /// <return>The next stage of the update.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithTrafficDisabledOrEnabled.WithTrafficEnabled()
        {
            return this.WithTrafficEnabled();
        }

        /// <summary>
        /// Specifies that the endpoint should be excluded from receiving traffic.
        /// </summary>
        /// <return>The next stage of the update.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithTrafficDisabledOrEnabled.WithTrafficDisabled()
        {
            return this.WithTrafficDisabled();
        }

        /// <summary>
        /// Specifies the FQDN of an external endpoint that is not hosted in Azure.
        /// </summary>
        /// <param name="externalFqdn">The external FQDN.</param>
        /// <return>The next stage of the endpoint update.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateExternalEndpoint.IUpdateExternalEndpoint Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithFqdn.ToFqdn(string externalFqdn)
        {
            return this.ToFqdn(externalFqdn);
        }

        /// <summary>
        /// Specifies the resource ID of an Azure resource.
        /// supported Azure resources are cloud service, web app or public ip.
        /// </summary>
        /// <param name="resourceId">The Azure resource id.</param>
        /// <return>The next stage of the update.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithAzureResource.ToResourceId(string resourceId)
        {
            return this.ToResourceId(resourceId);
        }

        /// <summary>
        /// Attaches the child definition to the parent resource update.
        /// </summary>
        /// <return>The next stage of the parent definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Update.IInUpdate<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate>.Attach()
        {
            return this.Attach();
        }

        /// <summary>
        /// Specifies the weight for the endpoint that will be used when the parent profile is configured with
        /// Weighted routing method  TrafficRoutingMethod.WEIGHTED.
        /// </summary>
        /// <param name="weight">The endpoint weight.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithRoutingWeight<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate>.WithRoutingWeight(int weight)
        {
            return this.WithRoutingWeight(weight);
        }

        /// <summary>
        /// Specifies the weight for the endpoint that will be used when the weight-based routing method
        /// TrafficRoutingMethod.WEIGHTED is enabled on the profile.
        /// </summary>
        /// <param name="weight">The endpoint weight.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithRoutingWeight<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate>.WithRoutingWeight(int weight)
        {
            return this.WithRoutingWeight(weight);
        }

        /// <summary>
        /// Specifies the minimum number of endpoints to be online for the nested profile to be considered healthy.
        /// </summary>
        /// <param name="count">The number of endpoints.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithEndpointThreshold<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate>.WithMinimumEndpointsToEnableTraffic(int count)
        {
            return this.WithMinimumEndpointsToEnableTraffic(count);
        }

        /// <summary>
        /// Specifies the minimum number of endpoints to be online for the nested profile to be considered healthy.
        /// </summary>
        /// <param name="count">The number of endpoints.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithEndpointThreshold<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate>.WithMinimumEndpointsToEnableTraffic(int count)
        {
            return this.WithMinimumEndpointsToEnableTraffic(count);
        }

        /// <summary>
        /// Specifies the weight for the endpoint that will be used when the weight-based routing method
        /// TrafficRoutingMethod.WEIGHTED is enabled on the profile.
        /// </summary>
        /// <param name="weight">The endpoint weight.</param>
        /// <return>The next stage of the update.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithRoutingWeight.WithRoutingWeight(int weight)
        {
            return this.WithRoutingWeight(weight);
        }

        /// <summary>
        /// Specifies the priority for the endpoint that will be used when the parent profile is configured with
        /// Subnet routing method  TrafficRoutingMethod.SUBNET.
        /// </summary>
        /// <param name="first">first address of the range.</param>
        /// <param name="last">last address of the range.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithSubnetRouting.WithSubnetRouting(string first, string last)
        {
            return this.WithSubnetRouting(first, last);
        }

        /// <summary>
        /// Specifies the priority for the endpoint that will be used when the parent profile is configured with
        /// Subnet routing method  TrafficRoutingMethod.SUBNET.
        /// </summary>
        /// <param name="ipAddress">first address of the range.</param>
        /// <param name="mask">last address of the range.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithSubnetRouting.WithSubnetRouting(string ipAddress, int mask)
        {
            return this.WithSubnetRouting(ipAddress, mask);
        }

        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithCustomHeaders.WithCustomHeaders(IDictionary<string, string> headers)
        {
            return this.WithCustomHeaders(headers);
        }

        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithCustomHeaders.WithCustomHeader(string name, string value)
        {
            return this.WithCustomHeader(name, value);
        }


        /// <summary>
        /// Specifies a nested traffic manager profile for the endpoint.
        /// </summary>
        /// <param name="profile">The nested traffic manager profile.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithSourceTrafficRegionThenThreshold<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithNestedProfile<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate>.ToProfile(ITrafficManagerProfile profile)
        {
            return this.ToProfile(profile);
        }

        /// <summary>
        /// Specifies a nested traffic manager profile for the endpoint.
        /// </summary>
        /// <param name="profile">The nested traffic manager profile.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithSourceTrafficRegionThenThreshold<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithNestedProfile<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate>.ToProfile(ITrafficManagerProfile profile)
        {
            return this.ToProfile(profile);
        }

        /// <summary>
        /// Attaches the child definition to the parent resource definiton.
        /// </summary>
        /// <return>The next stage of the parent definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Definition.IInDefinition<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate>.Attach()
        {
            return this.Attach();
        }

        /// <summary>
        /// Specifies the FQDN of an external endpoint.
        /// </summary>
        /// <param name="externalFqdn">The external FQDN.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithSourceTrafficRegion<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithFqdn<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate>.ToFqdn(string externalFqdn)
        {
            return this.ToFqdn(externalFqdn);
        }

        /// <summary>
        /// Specifies the FQDN of an external endpoint.
        /// </summary>
        /// <param name="externalFqdn">The external FQDN.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithSourceTrafficRegion<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithFqdn<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate>.ToFqdn(string externalFqdn)
        {
            return this.ToFqdn(externalFqdn);
        }

        /// <summary>
        /// Specifies the weight for the endpoint that will be used when priority-based routing method
        /// is  TrafficRoutingMethod.PRIORITY enabled on the profile.
        /// </summary>
        /// <param name="priority">The endpoint priority.</param>
        /// <return>The next stage of the update.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithRoutingPriority.WithRoutingPriority(int priority)
        {
            return this.WithRoutingPriority(priority);
        }

        /// <summary>
        /// Specifies the location of the endpoint that will be used when the parent profile is configured with
        /// Performance routing method  TrafficRoutingMethod.PERFORMANCE.
        /// </summary>
        /// <param name="region">The location.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithSourceTrafficRegion<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate>.FromRegion(Microsoft.Azure.Management.ResourceManager.Fluent.Core.Region region)
        {
            return this.FromRegion(region);
        }

        /// <summary>
        /// Specifies the location of the endpoint that will be used when the parent profile is configured with
        /// Performance routing method  TrafficRoutingMethod.PERFORMANCE.
        /// </summary>
        /// <param name="region">The location.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithSourceTrafficRegion<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate>.FromRegion(Microsoft.Azure.Management.ResourceManager.Fluent.Core.Region region)
        {
            return this.FromRegion(region);
        }

        /// <summary>
        /// Specifies the resource ID of an Azure resource.
        /// supported Azure resources are cloud service, web app or public ip.
        /// </summary>
        /// <param name="resourceId">The Azure resource id.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Definition.IWithAzureResource<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Definition.IWithCreate>.ToResourceId(string resourceId)
        {
            return this.ToResourceId(resourceId);
        }

        /// <summary>
        /// Specifies the resource ID of an Azure resource.
        /// supported Azure resources are cloud service, web app or public ip.
        /// </summary>
        /// <param name="resourceId">The Azure resource id.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate> Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateDefinition.IWithAzureResource<Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerProfile.Update.IUpdate>.ToResourceId(string resourceId)
        {
            return this.ToResourceId(resourceId);
        }

        /// <summary>
        /// Specifies the region of the endpoint that will be used when the performance-based routing method
        /// TrafficRoutingMethod.PERFORMANCE is enabled on the profile.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <return>The next stage of the endpoint update.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IUpdate Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithSourceTrafficRegion.FromRegion(Microsoft.Azure.Management.ResourceManager.Fluent.Core.Region location)
        {
            return this.FromRegion(location);
        }

        /// <summary>
        /// Specifies the minimum number of endpoints to be online for the nested profile to be considered healthy.
        /// </summary>
        /// <param name="count">Number of endpoints.</param>
        /// <return>The next stage of the endpoint update.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateNestedProfileEndpoint.IUpdateNestedProfileEndpoint Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithNestedProfileConfig.WithMinimumEndpointsToEnableTraffic(int count)
        {
            return this.WithMinimumEndpointsToEnableTraffic(count);
        }

        /// <summary>
        /// Specifies a nested traffic manager profile for the endpoint.
        /// </summary>
        /// <param name="nestedProfile">The nested traffic manager profile.</param>
        /// <return>The next stage of the update.</return>
        Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.UpdateNestedProfileEndpoint.IUpdateNestedProfileEndpoint Microsoft.Azure.Management.TrafficManager.Fluent.TrafficManagerEndpoint.Update.IWithNestedProfileConfig.ToProfile(ITrafficManagerProfile nestedProfile)
        {
            return this.ToProfile(nestedProfile);
        }

        /// <summary>
        /// Gets the geographic location codes indicating the locations to which traffic will be distributed.
        /// </summary>
        System.Collections.Generic.IReadOnlyList<string> Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerEndpoint.GeographicLocationCodes
        {
            get
            {
                return this.GeographicLocationCodes();
            }
        }

        /// <summary>
        /// Gets the priority of the endpoint which is used when traffic manager profile is configured with
        /// Priority traffic-routing method.
        /// </summary>
        long Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerEndpoint.RoutingPriority
        {
            get
            {
                return this.RoutingPriority();
            }
        }

        /// <summary>
        /// Gets the endpoint type.
        /// </summary>
        Microsoft.Azure.Management.TrafficManager.Fluent.EndpointType Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerEndpoint.EndpointType
        {
            get
            {
                return this.EndpointType();
            }
        }

        /// <summary>
        /// Gets the monitor status of the endpoint.
        /// </summary>
        Microsoft.Azure.Management.TrafficManager.Fluent.EndpointMonitorStatus Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerEndpoint.MonitorStatus
        {
            get
            {
                return this.MonitorStatus();
            }
        }

        /// <summary>
        /// Gets the weight of the endpoint which is used when traffic manager profile is configured with
        /// Weighted traffic-routing method.
        /// </summary>
        long Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerEndpoint.RoutingWeight
        {
            get
            {
                return this.RoutingWeight();
            }
        }

        /// <summary>
        /// Gets true if the endpoint is enabled, false otherwise.
        /// </summary>
        bool Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerEndpoint.IsEnabled
        {
            get
            {
                return this.IsEnabled();
            }
        }

        /// <summary>
        /// Gets the monitor custom headers
        /// </summary>
        System.Collections.Generic.IReadOnlyDictionary<string, string> Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerEndpoint.CustomHeaders
        {
            get
            {
                return this.CustomHeaders();
            }
        }

        /// <summary>
        /// Gets the subnet route for the subnet routing feature
        /// </summary>
        System.Collections.Generic.IReadOnlyCollection<string> Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerEndpoint.SubnetRoute
        {
            get
            {
                return this.SubnetRoute();
            }
        }
    }
}