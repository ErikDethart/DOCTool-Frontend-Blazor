using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;

namespace BlazorApp.Data {
    public class TeamViewerService : ITeamViewerService{
            private readonly HttpClient httpClient;

            public TeamViewerService(HttpClient httpClient)
            {
                this.httpClient = httpClient;
            }

            public async Task<IEnumerable<TeamViewer>> GetIDsAsync()
            {
                return await httpClient.GetFromJsonAsync<TeamViewer[]>("TeamViewer");
            }

            public async Task Delete(String hostName) {
                await httpClient.DeleteAsync("TeamViewer/" + hostName);
            }
    }
}
