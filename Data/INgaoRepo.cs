using System.Collections.Generic;
using NgaoApi.Models;

namespace NgaoApi.Data
{
    public interface INgaoRepo
    {
        bool saveChanges();

        IEnumerable<ngao> GetAllCommands();
        ngao GetCommandById(int id);
        void createngao(ngao cmd);

        void updatengao(ngao cmd);

    }
}