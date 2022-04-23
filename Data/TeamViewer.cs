using System;
using System.Text.Json.Serialization;

namespace BlazorApp.Data
{
    public class TeamViewer
    {
        [JsonPropertyName("hostName")]
        public String HostName { get; set; }

        [JsonPropertyName("teamViewerID")]
        public String TeamViewerID { get; set; }
    }
}
