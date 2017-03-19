﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Ews.RestExtensions.Client.Proxy.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// A Container is the parent for other types; namely Value, Alarm,
    /// Container, Trend, and Enum.
    /// </summary>
    public partial class ContainerModel
    {
        /// <summary>
        /// Initializes a new instance of the ContainerModel class.
        /// </summary>
        public ContainerModel() { }

        /// <summary>
        /// Initializes a new instance of the ContainerModel class.
        /// </summary>
        public ContainerModel(string name = default(string), string description = default(string), string type = default(string), string parentId = default(string), string id = default(string))
        {
            Name = name;
            Description = description;
            Type = type;
            ParentId = parentId;
            Id = id;
        }

        /// <summary>
        /// Name of the Container.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional description of the Container.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the type of the Container. Possible values include:
        /// 'Folder', 'Server', 'Device', 'Structure', 'Service'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// Id of the Container which the Container is found in.
        /// </summary>
        [JsonProperty(PropertyName = "ParentId")]
        public string ParentId { get; set; }

        /// <summary>
        /// Case sensitive identifier for the entity.
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

    }
}