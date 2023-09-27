using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace MK.IO.Models
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class AssetFilterListResponseSchema
    {
        /// <summary>
        /// A list of asset filters
        /// </summary>
        /// <value>A list of asset filters</value>
        [DataMember(Name = "filters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "filters")]
        public List<AssetFilterSchema> Filters { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetFilterListResponseSchema {\n");
            sb.Append("  Value: ").Append(Filters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
