﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using MK.IO.Models;
using Newtonsoft.Json;

namespace MK.IO
{

    public partial class BaseObjectStorage
    {
        public static BaseObjectStorage FromJson(string json)
        {
            return JsonConvert.DeserializeObject<BaseObjectStorage>(json, ConverterLE.Settings);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, ConverterLE.Settings);
        }

        public BaseObjectStorage(StorageSpec storage)
        {

            Spec = storage;

        }

        [JsonProperty("spec")]
        public StorageSpec Spec { get; set; }

        [JsonProperty("metadata")]
        public StorageMetadata Metadata { get; set; }
     
    }


    public class StorageSpec
    {
        public StorageSpec(string name, string location, Uri SASUrl, string? description = null)
        {

            Type = "Microsoft.Storage";
            Name = name;
            Location = location;
            Description = description;
            AzureStorageConfiguration = new AzureStorageConfiguration() { Url = SASUrl } ;

        }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("azureStorageConfiguration")]
        public AzureStorageConfiguration AzureStorageConfiguration { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }
    }

    public class AzureStorageConfiguration
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public class StorageMetadata
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("createdById")]
        public Guid CreatedById { get; set; }

        [JsonProperty("updatedById")]
        public Guid UpdatedById { get; set; }

        [JsonProperty("activeCredentialId")]
        public Guid ActiveCredentialId { get; set; }
    }
}