using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamarinMALDemo3.Interfaces
{
    public interface IPollService
    {
        Task<IList<IPoll>> GetPollsAsync();
    }
}
