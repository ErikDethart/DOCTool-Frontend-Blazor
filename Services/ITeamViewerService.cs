using System.Threading.Tasks;
using System.Collections.Generic;

namespace BlazorApp.Data {
    public interface ITeamViewerService {
        Task<IEnumerable<TeamViewer>> GetIDsAsync();
        Task Delete(string hostName);
    }
}