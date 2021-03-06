// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.TimeSeriesInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Time series instances are the time series themselves. In most cases,
    /// the deviceId or assetId is the unique identifier of the asset in the
    /// environment. Instances have descriptive information associated with
    /// them called instance fields. At a minimum, instance fields include
    /// hierarchy information. They can also include useful, descriptive data
    /// like the manufacturer, operator, or the last service date.
    /// </summary>
    public partial class TimeSeriesInstance
    {
        /// <summary>
        /// Initializes a new instance of the TimeSeriesInstance class.
        /// </summary>
        public TimeSeriesInstance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TimeSeriesInstance class.
        /// </summary>
        /// <param name="timeSeriesId">Time Series ID that uniquely identifies
        /// the instance. It matches Time Series ID properties in an
        /// environment. Immutable, never null.</param>
        /// <param name="typeId">This represents the type that this instance
        /// belongs to. Never null.</param>
        /// <param name="name">Optional name of the instance which is unique in
        /// an environment. Names acts as a mutable alias or display name of
        /// the time series instance. Mutable, may be null.</param>
        /// <param name="description">This optional field contains description
        /// about the instance.</param>
        /// <param name="hierarchyIds">Set of time series hierarchy IDs that
        /// the instance belong to. May be null.</param>
        /// <param name="instanceFields">Set of key-value pairs that contain
        /// user-defined instance properties. It may be null. Supported
        /// property value types are: bool, string, long, double and it cannot
        /// be nested or null.</param>
        public TimeSeriesInstance(IList<object> timeSeriesId, string typeId, string name = default(string), string description = default(string), IList<string> hierarchyIds = default(IList<string>), IDictionary<string, object> instanceFields = default(IDictionary<string, object>))
        {
            TimeSeriesId = timeSeriesId;
            TypeId = typeId;
            Name = name;
            Description = description;
            HierarchyIds = hierarchyIds;
            InstanceFields = instanceFields;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets time Series ID that uniquely identifies the instance.
        /// It matches Time Series ID properties in an environment. Immutable,
        /// never null.
        /// </summary>
        [JsonProperty(PropertyName = "timeSeriesId")]
        public IList<object> TimeSeriesId { get; set; }

        /// <summary>
        /// Gets or sets this represents the type that this instance belongs
        /// to. Never null.
        /// </summary>
        [JsonProperty(PropertyName = "typeId")]
        public string TypeId { get; set; }

        /// <summary>
        /// Gets or sets optional name of the instance which is unique in an
        /// environment. Names acts as a mutable alias or display name of the
        /// time series instance. Mutable, may be null.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets this optional field contains description about the
        /// instance.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets set of time series hierarchy IDs that the instance
        /// belong to. May be null.
        /// </summary>
        [JsonProperty(PropertyName = "hierarchyIds")]
        public IList<string> HierarchyIds { get; set; }

        /// <summary>
        /// Gets or sets set of key-value pairs that contain user-defined
        /// instance properties. It may be null. Supported property value types
        /// are: bool, string, long, double and it cannot be nested or null.
        /// </summary>
        [JsonProperty(PropertyName = "instanceFields")]
        public IDictionary<string, object> InstanceFields { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TimeSeriesId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TimeSeriesId");
            }
            if (TypeId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TypeId");
            }
        }
    }
}
