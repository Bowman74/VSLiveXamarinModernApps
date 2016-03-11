using System;
using System.Collections.Generic;
using System.Text;
using XamarinMALDemo2.Interfaces;

namespace XamarinMALDemo2.iOS.Services
{
    public class NetworkService : INetworkService
    {
        public bool HasNetworkConnection()
        {
            return true;
        }
    }
}
