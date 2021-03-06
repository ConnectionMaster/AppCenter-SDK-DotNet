// <auto-generated>
// Copyright (c) Microsoft Corporation.  All rights reserved.
// </auto-generated>

namespace Microsoft.AppCenter.Ingestion.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Required explicit begin session log (a marker event for analytics
    /// service).
    /// </summary>
    [Newtonsoft.Json.JsonObject("startSession")]
    public partial class StartSessionLog : Log
    {
        /// <summary>
        /// Initializes a new instance of the StartSessionLog class.
        /// </summary>
        public StartSessionLog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StartSessionLog class.
        /// </summary>
        /// <param name="timestamp">Log timestamp, example:
        /// '2017-03-13T18:05:42Z'.
        /// </param>
        /// <param name="sid">When tracking an analytics session, logs can be
        /// part of the session by specifying this identifier.
        /// This attribute is optional, a missing value means the session
        /// tracking is disabled (like when using only error reporting
        /// feature).
        /// Concrete types like StartSessionLog or PageLog are always part of a
        /// session and always include this identifier.
        /// </param>
        /// <param name="userId">optional string used for associating logs with
        /// users.
        /// </param>
        /// <param name="distributionGroupId">Distribution group
        /// identifier.</param>
        public StartSessionLog(Device device, System.DateTime? timestamp = default(System.DateTime?), System.Guid? sid = default(System.Guid?), string userId = default(string), System.Guid? distributionGroupId = default(System.Guid?))
            : base(device, timestamp, sid, userId)
        {
            DistributionGroupId = distributionGroupId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets distribution group identifier.
        /// </summary>
        [JsonProperty(PropertyName = "distributionGroupId")]
        public System.Guid? DistributionGroupId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
