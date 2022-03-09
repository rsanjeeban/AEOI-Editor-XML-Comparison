using Newtonsoft.Json;
using System.Collections.Generic;

namespace AEOI.Editor.Web.Shared.Models
{
    public class XmlDifference
    {
        public List<Difference> DiffNodeList { get; set; }
    }
    public class Difference
    {
        [JsonProperty("Edit")]
        public string Edit { get; set; }

        [JsonProperty("XPath")]
        public string XPath { get; set; }

        [JsonProperty("DiffID")]
        public string DiffID { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("LocalName")]
        public string LocalName { get; set; }
        
        [JsonProperty("ValueFrom")]
        public string ValueFrom { get; set; }

        [JsonProperty("ValueTo")]
        public string ValueTo { get; set; }
        [JsonProperty("Account")]
        public string Account { get; set; }
        [JsonProperty("Fi")]
        public string Fi { get; set; }

        [JsonProperty("NodeType")]
        public string NodeType { get; set; }

        [JsonProperty("OriginLineNo")]
        public int OriginLineNo { get; set; }

        [JsonProperty("CompLineNo")]
        public int CompLineNo { get; set; }
    }
}
