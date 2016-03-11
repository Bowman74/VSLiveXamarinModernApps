using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinMALDemo1.Interfaces;
using XamarinMALDemo1.Models;

namespace XamarinMALDemo1.Services
{
    public class PollService : IPollService
    {
        public async Task<IList<IPoll>> GetPollsAsync()
        {
            return await Task.Run(() => GetPolls());
        }

        private IList<IPoll> GetPolls()
        {
            var returnValue = new List<IPoll>
            {
                new Poll
                {
                    NumberResponses = 3,
                    PollDescription = "Entertainment",
                    PollQuestion = "What is your favorite movie?"
                },
                new Poll
                {
                    NumberResponses = 1,
                    PollDescription = "Entertainment",
                    PollQuestion = "Will Batman or Superman win their fight?"
                },
                new Poll
                {
                    NumberResponses = 34564,
                    PollDescription = "Politics",
                    PollQuestion = "Who will win the Republican Primary?"
                }
            };
            return returnValue;
        } 
    }
}