using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamarinMALDemo.Interfaces
{
    public interface IPollService
    {
        Task<IList<IPoll>> GetPollsAsync();
    }
}
