using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamarinMALDemo1.Interfaces
{
    public interface IPollService
    {
        Task<IList<IPoll>> GetPollsAsync();
    }
}
