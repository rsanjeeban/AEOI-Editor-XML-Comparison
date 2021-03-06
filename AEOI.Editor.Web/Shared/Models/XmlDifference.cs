using Newtonsoft.Json;
using System.Collections.Generic;

namespace AEOI.Editor.Web.Shared.Models
{
    public enum DiffTypes { Removed, Added, Changed }
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
        public DiffTypes DiffType { get; set; }

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
        
        [JsonProperty("ControllingPerson")]
        public string ControllingPerson { get; set; }

        [JsonProperty("NodeType")]
        public string NodeType { get; set; }

        [JsonProperty("OriginLineNo")]
        public int OriginLineNo { get; set; }

        [JsonProperty("CompLineNo")]
        public int CompLineNo { get; set; }
        
        public string userName { get; set; }
        public string dateOfFileModified { get; set; }
        public string timeOfFileModified { get; set; }
        public string snapShotName { get; set; }
    }

    public class DifferenceList
    {
        public XmlDifference FiDifference { get; set; }
        public XmlDifference AccountDifference { get; set; }
        public XmlDifference ControllingPersonsDifference { get; set; }
        public DifferenceList()
        {
        }

        public DifferenceList(XmlDifference fiDifference, XmlDifference accountDifference, XmlDifference controllingPersonsDifference)
        {
            FiDifference = fiDifference;
            AccountDifference = accountDifference;
            ControllingPersonsDifference = controllingPersonsDifference;
        }
    }
}
