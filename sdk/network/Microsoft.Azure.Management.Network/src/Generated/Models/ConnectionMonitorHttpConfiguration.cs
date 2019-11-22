// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes the HTTP configuration.
    /// </summary>
    public partial class ConnectionMonitorHttpConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectionMonitorHttpConfiguration class.
        /// </summary>
        public ConnectionMonitorHttpConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectionMonitorHttpConfiguration class.
        /// </summary>
        /// <param name="port">The port.</param>
        /// <param name="method">HTTP method. Possible values include: 'Get',
        /// 'Post'</param>
        /// <param name="path">The path.</param>
        /// <param name="requestHeaders">List of HTTP headers.</param>
        /// <param name="validStatusCodeRanges">A list of valid status code
        /// ranges.</param>
        /// <param name="preferHTTPS">Value indicating whether HTTPS is
        /// preferred over HTTP.</param>
        public ConnectionMonitorHttpConfiguration(int? port = default(int?), string method = default(string), string path = default(string), IList<HTTPHeader> requestHeaders = default(IList<HTTPHeader>), IList<string> validStatusCodeRanges = default(IList<string>), bool? preferHTTPS = default(bool?))
        {
            Port = port;
            Method = method;
            Path = path;
            RequestHeaders = requestHeaders;
            ValidStatusCodeRanges = validStatusCodeRanges;
            PreferHTTPS = preferHTTPS;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets HTTP method. Possible values include: 'Get', 'Post'
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets list of HTTP headers.
        /// </summary>
        [JsonProperty(PropertyName = "requestHeaders")]
        public IList<HTTPHeader> RequestHeaders { get; set; }

        /// <summary>
        /// Gets or sets a list of valid status code ranges.
        /// </summary>
        [JsonProperty(PropertyName = "validStatusCodeRanges")]
        public IList<string> ValidStatusCodeRanges { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether HTTPS is preferred over HTTP.
        /// </summary>
        [JsonProperty(PropertyName = "preferHTTPS")]
        public bool? PreferHTTPS { get; set; }

    }
}
