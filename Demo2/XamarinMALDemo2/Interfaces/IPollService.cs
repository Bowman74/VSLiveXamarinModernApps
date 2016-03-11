using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamarinMALDemo2.Interfaces
{
    public interface IPollService
    {
        Task<IList<IPoll>> GetPollsAsync();
    }
}
