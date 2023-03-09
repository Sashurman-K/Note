using Newtonsoft.Json;

namespace Notes.Models.Configure
{
    //Перенес в другое место и убрал словарь. А то он очень старшный
    [Serializable]
    public class ServiceConfigure
    {
        [JsonProperty("ConnectionStrings")]
        public string ConnectionStrings { get; set; }
    }
}
