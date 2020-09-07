using System.Collections.Generic;
using NgaoApi.Models;

namespace NgaoApi.Data
{
    public class MockNgaoRepo : INgaoRepo
    {
        public void createngao(ngao cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ngao> GetAllCommands()
        {
            var ngao = new List<ngao>
            {
                new ngao{id=0, HowTo="Test1", Line="Work1", platform="working kabisa1"},
                new ngao{id=1, HowTo="Test2", Line="Work2", platform="working kabisa2"},
                new ngao{id=2, HowTo="Test3", Line="Work3", platform="working kabisa3"},
            };

            return ngao;
        }

        public ngao GetCommandById(int id)
        {
            return new ngao{id=0, HowTo="Test", Line="Work", platform="working kabisa"};
        }

        public bool saveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void updatengao(ngao cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}