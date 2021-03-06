// Template: Models (ApiModel.t4) version 5.0

// This code was generated by AMF Server Scaffolder

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace CH09_RamlClient.Api.Models
{
    public partial class TestType
    {
        

        [Required]
        [MaxLength(0)]
        [MinLength(0)]
		[JsonProperty("id")]
        public decimal Id { get; set; }

        [MaxLength(0)]
        [MinLength(0)]
		[JsonProperty("optional?")]
        public string Optional { get; set; }

        [Required]
		[JsonProperty("expanded")]
        public Expanded Expanded { get; set; }
    } // end class

} // end Models namespace

