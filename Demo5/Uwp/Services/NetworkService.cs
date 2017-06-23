using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Connectivity;
using XamarinMALDemo.Interfaces;

namespace XamarinMALDemo.Uwp.Services
{
    public class NetworkService : INetworkService
    {
        public bool HasNetworkConnection()
        {
            var connections = NetworkInformation.GetInternetConnectionProfile();
            return connections != null && connections.GetNetworkConnectivityLevel() != NetworkConnectivityLevel.None;
        }
    }
}
