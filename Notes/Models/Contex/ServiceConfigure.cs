using Newtonsoft.Json;

namespace Notes.Models.Contex
{
        [Serializable]
        public class ServiceConfigure
        {
            [JsonProperty("ConnectionStrings")]
            public Dictionary<string, string> ConnectionStrings { get; set; }
        }
    
}
