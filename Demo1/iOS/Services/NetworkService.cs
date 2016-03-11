using System.Net;
using SystemConfiguration;
using CoreFoundation;
using XamarinMALDemo1.Interfaces;

namespace XamarinMALDemo1.iOS.Services
{
    public class NetworkService : INetworkService
    {
        public bool HasNetworkConnection()
        {
            NetworkReachabilityFlags flags;
            var defaultRouteReachability = new NetworkReachability(new IPAddress(0));
            defaultRouteReachability.Schedule(CFRunLoop.Current, CFRunLoop.ModeDefault);

            return defaultRouteReachability.TryGetFlags(out flags) && IsReachableWithoutRequiringConnection(flags);
        }

        public bool IsReachableWithoutRequiringConnection(NetworkReachabilityFlags flags)
        {
            // Is it reachable with the current network configuration?
            var isReachable = (flags & NetworkReachabilityFlags.Reachable) != 0;

            // Do we need a connection to reach it?
            var noConnectionRequired = (flags & NetworkReachabilityFlags.ConnectionRequired) == 0
                || (flags & NetworkReachabilityFlags.IsWWAN) != 0;

            return isReachable && noConnectionRequired;
        }
    }
}
