using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GlobalX.ChatBots.Core.People;

namespace GlobalX.ChatBots.WebexTeams.People
{
    public class WebexPersonHandler : IPersonHandler
    {
        public Task<Person> GetPersonAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}