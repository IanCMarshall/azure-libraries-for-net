// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.TrafficManager.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Subnet first address, scope, and/or last address.
    /// </summary>
    public partial class EndpointPropertiesSubnetsItem
    {
        /// <summary>
        /// Initializes a new instance of the EndpointPropertiesSubnetsItem
        /// class.
        /// </summary>
        public EndpointPropertiesSubnetsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EndpointPropertiesSubnetsItem
        /// class.
        /// </summary>
        /// <param name="first">First address in the subnet.</param>
        /// <param name="last">Last address in the subnet.</param>
        /// <param name="scope">Block size (number of leading bits in the
        /// subnet mask).</param>
        public EndpointPropertiesSubnetsItem(string first = default(string), string last = default(string), int? scope = default(int?))
        {
            First = first;
            Last = last;
            Scope = scope;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets first address in the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "first")]
        public string First { get; set; }

        /// <summary>
        /// Gets or sets last address in the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "last")]
        public string Last { get; set; }

        /// <summary>
        /// Gets or sets block size (number of leading bits in the subnet
        /// mask).
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public int? Scope { get; set; }

    }
}