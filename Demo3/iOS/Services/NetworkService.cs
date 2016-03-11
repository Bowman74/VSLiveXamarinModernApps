using System;
using System.Collections.Generic;
using System.Text;
using XamarinMALDemo3.Interfaces;

namespace XamarinMALDemo3.iOS.Services
{
    public class NetworkService : INetworkService
    {
        public bool HasNetworkConnection()
        {
            return true;
        }
    }
}
